/*
https://www.acmicpc.net/problem/15596
C로 문제 풀기
*/

long long sum(int *a, int n) {
    long long result = 0;

    for(int i = 0; i < n; i++) {
        result += *(a+i);
    }

    return result;
}


/*
https://www.acmicpc.net/problem/4673
C로 문제 풀기
*/
#include <stdio.h>

int findNextNumber(int);
void printResult(int*);

int main(void) {
    int a[10001] = {0};
    int temp = 0, i = 1;

    do {
        temp = findNextNumber(i);
        if(temp <= 10000)
            a[temp]++;
        i++;
    } while(i <= 10000);

    printResult(a);
    return 0;
}

int findNextNumber(int n) {
    int result = n;

    while(n>0) {
        result += n % 10;
        n /= 10;
    }
    return result;
}

void printResult(int *a) {
    for(int i = 1; i <= 10000; i++) {
        if(a[i] == 0)
            printf("%d\n", i);
    }
}


/*
https://www.acmicpc.net/problem/1065
*/

#include <stdio.h>

int isHanNumber(int);

int main(void) {
    int num, count = 0;
    scanf("%d", &num);

    for(int i = 1; i <= num; i++) {
        if(isHanNumber(i))
            count++;
    }
    printf("%d\n", count);
    return 0;
}


int isHanNumber(int a) {
    int temp, editedA;

    if(a < 100)
        return 1; 

    temp = a%10;
    editedA = a / 10;
    temp = temp - editedA%10;

    if(temp == editedA%10 - editedA/10)    
        return 1;
    
    return 0;
}
/*
https://www.acmicpc.net/problem/11654
*/
#include <stdio.h>

int main(void) {
    char chars;
    scanf("%s", &chars);

    printf("%d", (int)chars);
    return 0;
}

/*
https://www.acmicpc.net/problem/10809
*/
#include <stdio.h>

int main(void) {
    char string[100];
    char alphabet[26] = {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};
    scanf("%s", string);

    int i = 0, temp = 0;
    while(*(string+i) != 0) {
        temp = (int)*(string+i) - 'a';
        if(alphabet[temp] == -1)
            alphabet[temp] = i;
        i++;
    }

    for(int i = 0; i < 26; i++) {
        printf("%d ", alphabet[i]);
    }
    
    return 0;
}


/*
https://www.acmicpc.net/problem/2675
*/
#include <stdio.h>

void printRepeat(char*, int);

int main(void) {
    int testCase;
    scanf("%d", &testCase);

    int times;
    char string[20];

    for(int i = 0; i < testCase; i++) {
        scanf("%d %s", &times, string);

        printRepeat(string, times);
    }
    return 0;
}

void printRepeat(char* string, int n) {
    int j = 0;
    while (j<20 && string[j] != 0) {
        for(int k = 0; k < n; k++) {
            printf("%c", *(string+j));
        }
        j++;
    }
    printf("\n");
}

/*
https://www.acmicpc.net/problem/1157
*/
#include <stdio.h>

int main(void) {
    char string[1000001];
    int alphabet[26] = {0,};

    scanf("%s", string);
    
    int i = 0, maxAlphabet = -1, maxCount = -1;

    while (string[i] != 0) {
        if(string[i] >= 'a') {
            string[i] = string[i] - 32;
        }
        alphabet[string[i] - 'A']++;
        i++;
    }

    for(i = 0; i < 26; i++) {
        if(maxCount < alphabet[i]) {
            maxCount = alphabet[i];
            maxAlphabet = i;
        } else if (maxCount == alphabet[i]) {
            maxAlphabet = -1;
        }
    }

    printf("%c", (maxAlphabet == -1)? '?':maxAlphabet+'A');
    return 0;
}

