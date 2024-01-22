#pragma once

#include "wl_server.h"

#include <iostream>
#include <string>
#include <stdio.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>
#include <netdb.h>
#include <sys/uio.h>
#include <sys/time.h>
#include <sys/wait.h>
#include <fcntl.h>
#include <fstream>
#include <vector>
#include <algorithm>
#include <thread>

namespace corewolf
{
    class engine
    {
        friend std::ostream &operator<<(std::ostream &os, const corewolf::engine *en);
        friend std::ostream &operator<<(std::ostream &os, const corewolf::engine en);

    private:
        const std::string server_ip = "127.0.1.1";
        unsigned int _client_sid;
        std::string _text;
        static corewolf::engine *_instance;
        std::vector<std::string> _defined_functions;
        std::vector<std::string> _valid_names;

        void _valid_name(std::string &name)
        {
            static const unsigned int len = 6;
            static const char alphanum[] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (name == "")
            {
                name.clear();
                name.reserve(len);
                for (unsigned int i = 0; i < len; ++i)
                    name += alphanum[rand() % (sizeof(alphanum) - 1)];
            }

            _valid_names.push_back(name);
        }

        engine()
        {
            std::ofstream py(wl_server::name);
            py << wl_server::code << std::endl;
            py.close();
            if (std::system(std::string("python3 " + wl_server::name + " &").c_str()) < 0)
                ;
            std::this_thread::sleep_for(std::chrono::milliseconds(2000));

            // setup a socket and connection tools
            struct hostent *host = gethostbyname(server_ip.c_str());
            sockaddr_in sendSockAddr;
            bzero((char *)&sendSockAddr, sizeof(sendSockAddr));
            sendSockAddr.sin_family = AF_INET;
            sendSockAddr.sin_addr.s_addr = inet_addr(inet_ntoa(*(struct in_addr *)*host->h_addr_list));

            sendSockAddr.sin_port = htons(wl_server::port);
            _client_sid = socket(AF_INET, SOCK_STREAM, 0);
            int status = connect(_client_sid, (sockaddr *)&sendSockAddr, sizeof(sendSockAddr));
            if (status < 0)
                std::cout << "Error connecting to socket!" << std::endl;
            else
                std::cout << "Connected to the server!" << std::endl;
        }

        static std::string _print_vector(const std::vector<std::string> &v)
        {
            std::string ret;
            for (unsigned int i = 0; i < v.size(); i++)
                ret += v[i] + (i == v.size() - 1 ? "" : ",");
            return ret;
        }

    public:
        static corewolf::engine *get()
        {
            if (_instance == nullptr)
                _instance = new corewolf::engine();
            return _instance;
        }

        corewolf::engine *execute(const std::string &input, std::string name = "")
        {
            char msg[wl_server::packet_size];
            memset(&msg, 0, sizeof(msg));
            _valid_name(name);
            std::string command = name + "=(" + input + ")";
            strcpy(msg, command.c_str());

            int bytes_read = 0;
            int bytes_written = 0;
            bytes_written += send(_client_sid, (char *)&msg, strlen(msg), 0);
            memset(&msg, 0, sizeof(msg));
            bytes_read += recv(_client_sid, (char *)&msg, sizeof(msg), 0);
            _text = msg;
            return this;
        }

        void define(const std::string &input)
        {
            if (std::find(_defined_functions.begin(), _defined_functions.end(), input) == _defined_functions.end())
                _defined_functions.push_back(input);
            this->execute(input);
        }

        void terminate()
        {
            close(_client_sid);
            _instance = nullptr;
        }

        // ##
    };

    engine *engine::_instance = nullptr;

    std::ostream &operator<<(std::ostream &os, const corewolf::engine en)
    {
        os << en._text;
        return os;
    }

    std::ostream &operator<<(std::ostream &os, const corewolf::engine *en)
    {
        os << en->_text;
        return os;
    }
}