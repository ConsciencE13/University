#include "factorial.h"

namespace factorial {
    unsigned long factorial(unsigned long f)
    {
        if (f == 0)
            return 1;
        return(f * factorial(f - 1));
    }
}