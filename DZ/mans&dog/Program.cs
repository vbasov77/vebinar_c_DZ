//Про друзей и собаку

int count = 0;
int dist = 10000;
int first_man = 1;
int second_man = 2;
int dog = 5;
int mans = 2;
int stop = 5;
int time = 0;

while (dist >= stop) {
    if (mans == 1) {
        time = dist / (first_man + dog);
        mans = 2;
        dist = dist - (first_man + second_man) * time;
        count++;
    }
    if (mans == 2) {
        time = dist / (second_man + dog);
        mans = 1;
        dist = dist - (first_man + second_man) * time;
        count++;
   }
}
Console.WriteLine(count);
