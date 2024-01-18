#include "engine.h"

int main(int argc, char *argv[])
{
    // argc = 3;
    // argv[1] = "127.0.1.1";
    // argv[2] = "11000";
    for (unsigned int j = 0; j < 100; j++)
    {
        corewolf::engine *en = corewolf::engine::get(); // new corewolf::engine(argc, argv);
        for (unsigned int i = 0; i < 100; i++)
            std::cout << en->execute("1+1") << std::endl;
        en->AASTriangle("", "", "");
        en->terminate();
    }
}

/* To run this program use the command-line below:
 *	Unix:           quotient -linkname "math -wstp"
 *	Mac or Windows: quotient -linkmode launch
 */

// #include <stdio.h>
// #include <iostream>
// #include <stdlib.h>
// #include "/usr/local/Wolfram/WolframEngine/13.3/SystemFiles/Links/WSTP/DeveloperKit/Linux-x86-64/CompilerAdditions/wstp.h"

// static void init_and_openlink(int argc, char *argv[]);

// WSENV ep = (WSENV)0;
// WSLINK lp = (WSLINK)0;

// int main(int argc, char *argv[])
// {
//     int pkt, m, n, q;

//     init_and_openlink(argc, argv);
//     const char *name;
//     name = WSLinkName(lp);
//     std::cout << "3 " << name << std::endl;

//     if (!WSPutNext(lp, WSTKFUNC))
//     { /* unable to put the function type to lp */
//     }

//     if (!WSPutArgCount(lp, 2))
//     { /* unable to put the number of arguments to lp */
//     }

//     if (!WSPutSymbol(lp, "Plus"))
//     { /* unable to put the symbol to lp */
//     }

//     if (!WSPutInteger32(lp, 2))
//     { /* unable to put the integer to lp */
//     }

//     if (!WSPutInteger32(lp, 3))
//     { /* unable to put the integer to lp */
//     }

//     if (!WSFlush(lp))
//     { /* unable to flush any buffered outgoing data to lp */
//     }

//     if (!WSPutFunction(lp, "Times", 2))
//     { /* unable to send the function to lp */
//         std::cout << "4" << std::endl;
//     }

//     std::cout << "5" << std::endl;

//     if (!WSPutInteger32(lp, 10))
//     { /* unable to send the integer to lp */
//     }

//     if (!WSPutInteger32(lp, 30))
//     { /* unable to send the integer to lp */
//     }

//     if (!WSEndPacket(lp))
//     { /* unable to send the end-of-packet sequence to lp */
//     }

//     if (!WSFlush(lp))
//     { /* unable flush any buffered outgoing data in lp */
//     }

//     /* skip any packets before the first ReturnPacket */
//     while ((pkt = WSNextPacket(lp), pkt) && pkt != RETURNPKT)
//         WSNewPacket(lp);

//     /* inside the ReturnPacket we expect an integer */
//     WSGetInteger(lp, &q);

//     printf("quotient = %d\n", q);

//     /* quit Mathematica */
//     WSPutFunction(lp, "Exit", 0);

//     return 0;
// }

// static void deinit(void)
// {
//     if (ep)
//         WSDeinitialize(ep);
// }

// static void closelink(void)
// {
//     if (lp)
//         WSClose(lp);
// }

// static void init_and_openlink(int argc, char *argv[])
// {
//     int err;

//     ep = WSInitialize((WSParametersPointer)0);
//     if (ep == (WSENV)0)
//         exit(1);
//     atexit(deinit);
//     std::cout << "1" << std::endl;

//     lp = WSOpenArgv(ep, argv, argv + argc, &err);
//     std::cout << "2 " << err << std::endl;
//     if (lp == (WSLINK)0)
//         exit(2);
//     atexit(closelink);
// }
