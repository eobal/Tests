
#include <stdio.h>
#include <time.h>

int main (int argc, char *argv[])
{

	time_t rawtime;
  	struct tm * timeinfo;
  	printf ("Hello world!\n");


  	time(&rawtime);
  	timeinfo = localtime(&rawtime);
  	printf("Current local time and date: %s", asctime(timeinfo));

	for (int i = 0; i < 5; i++)
	{
		printf("Loop %d\n", i);
	}
	
	return 0;
}