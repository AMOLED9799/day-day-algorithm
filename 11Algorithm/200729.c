/*
https://www.acmicpc.net/problem/2908
*/
#include <stdio.h>

int main(void) {
    char string[8];
    fgets(string, sizeof(string), stdin);

    int a = 0, b = 0;
    for(int i = 0; i < 3; i++) {
        a = a*10 + (string[2-i] - '0');
        b = b*10 + (string[6-i] - '0');
    }

    printf("%d",(a>b)? a:b);

    return 0;
}

/*
https://www.acmicpc.net/problem/5622
*/

#include <stdio.h>

int charToDial(char c) {
    if(c < 'A') {
        return 0;
    }
    else if(c <= 'C') {
        return 3;
    }
    else if (c <= 'F') {
        return 4;
    }
    else if (c <= 'I') {
        return 5;
    }
    else if (c <= 'L') {
        return 6;
    }
    else if (c <= 'O') {
        return 7;
    }
    else if (c <= 'S') {
        return 8;
    }
    else if (c <= 'V') {
        return 9;
    }
    else if (c <= 'Z') {
        return 10;
    }
    else
        return 0;
}

int main(void) {
    char string[16];
    fgets(string, sizeof(string), stdin);
    int sum = 0;

    for(int i = 0; i < sizeof(string); i++) {
        if(string[i] == 0) {
            break;
        }
        sum += charToDial(string[i]);
    }

    printf("%d", sum);
    return 0;
}

/*
https://www.acmicpc.net/problem/2941
*/
#include <stdio.h>

void CroaAlphabet(char* s) {
    int sum = 0;

    for(int i = 0;1; i++) {

        if(s[i] > 'z' || s[i] < 'a') break;

        sum ++;

        if(s[i] == 'c') {
            if(s[i+1] == '=' || s[i+1] == '-') {
                i++;
            }
        }
        else if (s[i] == 'd') {
            if(s[i+1] == '-') {
                i++;
            }
            else if (s[i+1] == 'z' && s[i+2] == '=') {
                i+=2;
            }
        }
        else if (s[i] == 'l') {
            if(s[i+1] == 'j') i++;
        }
        else if (s[i] == 'n') {
            if(s[i+1] == 'j') i++;
        }
        else if (s[i] == 's') {
            if(s[i+1] == '=') i++;
        }
        else if (s[i] == 'z') {
            if(s[i+1] == '=') i++;
        }
    }

    printf("%d",sum);
    return;
}

int main(void) {
    char string[102];
    // fgets(string, sizeof(string), stdin);
    scanf("%s", string);

    CroaAlphabet(string);

    return 0;
}

/*
https://www.acmicpc.net/problem/1316
*/

#include <stdio.h>

int groupWord(char* string) {
    int i = 0;
    int alphabet[26] = {0};
    char before = string[0];

    while (string[i] != 0) {
        // printf("%c, %d\n", string[i], alphabet[0]);
        if(before != string[i]) {
            
            if(alphabet[string[i]-'a'] != 0)  {
                return 0;
            }
            alphabet[before - 'a']++;
        }
        
        before = string[i];
        i++;
    }
    return 1;
}

int main(void) {
    char string[101];
    int limit, count = 0;

    scanf("%d", &limit);

    for(int i = 0; i < limit; i++) {
        scanf("%s", string);
        count += groupWord(string);
    }
    printf("%d", count);

    return 0;
}

/*
https://www.acmicpc.net/problem/1712
while로 직접 계산할게 아니라 그냥 나누기 하면 되는거였네.
조금 더 생각을 하고 코드로 옮겨야겠군
*/
#include <stdio.h>

int main(void) {
    int a, b, c;
    scanf("%d %d %d", &a, &b, &c);

    int i = 0, temp = c-b;
    if(temp <= 0) {
        printf("-1");
        return 0;
    }

        printf("%d", a/temp + 1);

    return 0;
}


