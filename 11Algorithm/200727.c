/*
https://www.acmicpc.net/problem/1152

공백 입력을 받으려면 scanf 가 아닌 gets를 써야하고, 오류를 피하기 위해 fgets를 쓰자.
*/
#include <stdio.h>

int checkAlphabet(char a) {
    if((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'))
        return 1;
    return 0;
}

int main(void) {
    char string[1000001];
    fgets(string, sizeof(string), stdin);

    int i = 0, continueS = 0, countWord = 0;
    while(string[i] != 0) {
        // printf("get : %d\n", (int)string[i]);

        if(checkAlphabet(string[i])) {
            if(checkAlphabet(string[i+1]) == 0) {
                countWord++;
            }
        }

        i++;
    }
    printf("%d", countWord);

    return 0;
}


