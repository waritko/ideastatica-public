#ifdef  CPPFEAAPIWRAPPER_EXPORTS 
/*Enabled as "export" while compiling the dll project*/
#define CPPFEAAPIWRAPPER_EXPORT __declspec(dllexport)  
#else
/*Enabled as "import" in the Client side for using already created dll file*/
#define CPPFEAAPIWRAPPER_EXPORT __declspec(dllimport)  
#endif