#include "engine.h"

int main(int argc, char *argv[])
{
    argc = 3;
    argv[1] = "127.0.1.1";
    argv[2] = "11000";
    corewolf::engine *en = new corewolf::engine(argc, argv);
    for (unsigned int i = 0; i < 10000; i++)
        std::cout << en->execute("1+1") << std::endl;
    en->AASTriangle("", "", "");
}