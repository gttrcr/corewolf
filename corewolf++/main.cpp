#include "engine.h"

int main(int argc, char *argv[])
{
    // argc = 3;
    // argv[1] = "127.0.1.1";
    // argv[2] = "11000";
    for (unsigned int j = 0; j < 100; j++)
    {
        corewolf::engine *en = corewolf::engine::get();
        for (unsigned int i = 0; i < 100; i++)
            std::cout << en->execute("1+1") << std::endl;
        en->AASTriangle("", "", "");
        en->terminate();
    }
}