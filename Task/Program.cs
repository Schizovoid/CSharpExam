Console.WriteLine("Введите количество элементов, которые Вы планируете ввести.");
int arraySize = Convert.ToInt32(Console.ReadLine());
string [] arr = new string[arraySize];
fillArray(arr);
string[] newArray = cutArray(arr);
printArray(newArray);



void fillArray(string[]arr){
for(int i = 0; i < arraySize; i++){
Console.WriteLine("Введите следующий элемент: ");
arr[i] = Convert.ToString(Console.ReadLine());
}
};

string[] cutArray(string[] arr){
string[] newArray = new string[arr.Length];
for(int i = 0; i < arr.Length; i++){
    char[] chars = arr[i].ToCharArray();
    if(chars.Length < 4){
        newArray[i] = arr[i];
    } else {
        newArray[i] = "X";
    }
}
return newArray;
}

void printArray(string[] arr){
Console.WriteLine("Результат: ");
for(int i = 0; i < arr.Length; i++){
    Console.Write(arr[i] + "; ");
}
};


// int index = Array.IndexOf(arr, arr[i]);
//     arrayList.RemoveAt(arrayList.IndexOf(index));
//     arr = (string[])arrayList.ToArray();

// arr = arr.Where(x => x.Equals(arr[i])).ToArray();