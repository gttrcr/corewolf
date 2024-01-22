#include <iostream>

namespace corewolf
{
    class wl_server
    {
    public:
        static const unsigned int packet_size = 131072;
        static const unsigned int port = 1642;
        static const std::string name;
        static const std::string code;
    };

    const std::string wl_server::name = "./wlserver.py";
    const std::string wl_server::code = R"(import socket
import _thread
import time
import errno
import sys
from wolframclient.evaluation import WolframLanguageSession
from wolframclient.language import wl, wlexpr

client_number = 0
first_incoming = False

def on_new_client(clientsocket, addr):
    global client_number
    while True:
        try:
            msg = clientsocket.recv()" +
                                        std::to_string(wl_server::packet_size) +
                                        R"()
            if not msg:
                # print('Close connection from', addr)
                clientsocket.close()
                client_number -= 1
                break
            else:
                result = session.evaluate(wlexpr(msg))
                clientsocket.send(str.encode(str(result)))
        except socket.error as e:
            if e.args[0] == errno.EWOULDBLOCK:
                time.sleep(0.001)
            else:
                # print('Close connection from', addr)
                clientsocket.close()
                client_number -= 1
                break
        except:
            # print('Close connection from', addr)
            clientsocket.close()
            client_number -= 1
            break

s = socket.socket()
host = socket.gethostbyname(socket.gethostname())
port = )" + std::to_string(wl_server::port) +
                                        R"(

# print('Server started!')
# print('Waiting for clients...')

try:
    s.bind(('', port))
except:
    s.close()
    sys.exit(0)

s.listen(5)
s.setblocking(0)
# print('Starting WolframLanguageSession...')

try:
    session = WolframLanguageSession()
    session.evaluate(wlexpr('0'))
    # print('WolframLanguageSession() ok')

    while True:
        try:
            if client_number == 0 and first_incoming:
                # print('No connections left. Closing')
                break

            c, addr = s.accept()
            client_number += 1
            first_incoming = True
            # print('Got connection from', addr, 'number', client_number)
            _thread.start_new_thread(on_new_client, (c, addr))
        except:
            time.sleep(0.1)
except:
    pass
finally:
    # print('Closing')
    s.close()
    session.terminate()
)";
}