// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

#define EXPORT_METHOD extern "C" __declspec(dllexport)

EXPORT_METHOD
int MultiplyTwoNumbers(int a, int b) {
    return a * b;
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

