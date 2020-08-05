
/*
https://www.acmicpc.net/problem/10250
*/
#include <stdio.h>

int main(void) {
    int num;
    int h, w, n;
    int resulth, resultw;

    scanf("%d", &num);

    for(int i = 0; i < num; i++) {
        scanf("%d %d %d", &h, &w, &n);
        resulth = (n % h == 0)? h : n%h;
        resultw = (n%h==0)? n/h:n/h+1;
        printf("%d%02d\n", resulth, resultw);
    }
}

/*
https://www.acmicpc.net/problem/2775
*/
#include <stdio.h>

int main(void) {
    int num;
    scanf("%d", &num);

    int apartment[15][15] = {0, };
    int temp;

    for(int i = 0; i < 15; i++) {
        apartment[0][i] = i;
    }

    for(int j = 1; j < 15; j++) {
        for (int l = 1; l < 15; l++) {
                apartment[j][l] = apartment[j-1][l] + apartment[j][l-1];
        }
    }

    int k, n;
    for(int i = 0; i < num; i++) {
        scanf("%d %d", &k, &n);
        printf("%d\n", apartment[k][n]);
    }

    return 0;
}

