// Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

Console.WriteLine("Введите рост 1-ого спортсмена в см: ");
int height1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рост 2-ого спортсмена в см: ");
int height2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рост 3-ого спортсмена в см: ");
int height3 = Convert.ToInt32(Console.ReadLine());

int[] myArr = new int[3] {height1, height2, height3};
int i, j, temp;
for(i=0;i<3;i++) {
    Console.Write("{0} ",myArr[i]);
}
for(i=0; i<3; i++) {
    for(j=i+1; j<3; j++) {
        if(myArr[i] < myArr[j]) {
            temp = myArr[i];
            myArr[i] = myArr[j];
            myArr[j] = temp;
        }
    }
}
Console.Write("\nDescending order:\n");
for(i=0; i<3; i++) {
    Console.Write("{0} ", myArr[i]);
}