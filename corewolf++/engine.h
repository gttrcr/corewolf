#pragma once

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

        engine() // int argc, char *argv[])
        {
            std::system("python3 ./wlserver.py &");
            std::this_thread::sleep_for(std::chrono::milliseconds(2000));
            char *serverIp = "127.0.1.1";
            int port = 1642;

            // setup a socket and connection tools
            struct hostent *host = gethostbyname(serverIp);
            sockaddr_in sendSockAddr;
            bzero((char *)&sendSockAddr, sizeof(sendSockAddr));
            sendSockAddr.sin_family = AF_INET;
            sendSockAddr.sin_addr.s_addr = inet_addr(inet_ntoa(*(struct in_addr *)*host->h_addr_list));

            sendSockAddr.sin_port = htons(port);
            _client_sid = socket(AF_INET, SOCK_STREAM, 0);
            int status = connect(_client_sid, (sockaddr *)&sendSockAddr, sizeof(sendSockAddr));
            if (status < 0)
                std::cout << "Error connecting to socket!" << std::endl;
            else
                std::cout << "Connected to the server!" << std::endl;
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
            char msg[1500];
            memset(&msg, 0, sizeof(msg)); // clear the buffer
            _valid_name(name);
            std::string command = name + "=(" + input + ")";
            strcpy(msg, command.c_str());

            int bytesRead, bytesWritten = 0;
            bytesWritten += send(_client_sid, (char *)&msg, strlen(msg), 0);
            // std::cout << "Awaiting server response..." << std::endl;
            memset(&msg, 0, sizeof(msg)); // clear the buffer
            bytesRead += recv(_client_sid, (char *)&msg, sizeof(msg), 0);
            // if (!strcmp(msg, "exit"))
            // std::cout << "Server has quit the session" << std::endl;

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

        corewolf::engine *AASTriangle(const std::string &arg0, const std::string &arg1, const std::string &arg2, const std::string &name = "")
        {
            return this->execute("AASTriangle[" + arg0 + "," + arg1 + "," + arg2 + "]", name);
        }
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