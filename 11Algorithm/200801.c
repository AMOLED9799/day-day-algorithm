/*
https://www.acmicpc.net/problem/2839
*/
#include <stdio.h>

int main(void) {
    int a;
    scanf("%d", &a);

    int fkg = 0, tkg = 0;
    while (1) {
        if(a%5 == 0) {
            fkg = a/5;
            break;
        }

        a -= 3;
        tkg++;

        if(a < 0) {
            printf("-1"); return 0;
        }
    }

    printf("%d", fkg + tkg);
    return 0;
}

/*
https://www.acmicpc.net/problem/2292
*/
#include <stdio.h>

int main(void) {
    int a;
    scanf("%d", &a);

    int temp = 1, count = 0;

    do {
        temp = temp + count * 6;
        count++;
    } while(temp < a);

    printf("%d",count);
    return 0;
}


/*
https://www.acmicpc.net/problem/1193
*/
#include <stdio.h>

int main(void) {
    int a;
    scanf("%d", &a);

    int temp = 1, count = 0;
    while(temp <= a) {
        temp += count;
        count++;
    }
    
    int i = count; // 분자 분모 합
    int j = a-(temp-count+1); // 몇 번째 인가?

    if(count%2) {
        printf("%d/%d", j+1, count-j-1);
    }
    else {
        printf("%d/%d", count-j-1, j+1);
    }
    return 0;

}


/*
https://www.acmicpc.net/problem/2869
*/
#include <stdio.h>

int main(void) {
    int a,b,c;
    scanf("%d %d %d", &a, &b, &c);

    int count = ((c-a)%(a-b) == 0)? (c-a)/(a-b)+1 : (c-a)/(a-b)+2;
    printf("%d", count);
    return 0;

}


