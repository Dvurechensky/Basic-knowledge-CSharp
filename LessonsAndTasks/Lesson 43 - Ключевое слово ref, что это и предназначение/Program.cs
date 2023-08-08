using System;

/*
 * Ключевое слово ref 
 */
/*
 * Передача аргументов по ссылке 
 */
/*
 * ДЗ №1
 * Написать метод Resize() изменяющий количество элементов массива 
 * (метод должен иметь возможность увеличить или уменьшить число элементов массива)
 * 
 * ДЗ №2
 * Написать методы для добавления элемента в начало массива, в
 * конец массива и по указанному индексу
 * 
 * ДЗ №3
 * Написать методы для удаления первого элемента массива,
 * последнего элемента массива и элемента по указанному индексу
 * 
 */
class Program
{
    /// <summary>
    /// ДЗ №1
    /// </summary>
    /// <param name="myArray">#</param>
    /// <param name="counElements">#</param>
    /// <returns></returns>
    public static ref int[] Resize(ref int[] myArray, int counElements)
    {
        myArray = new int[counElements];
        return ref myArray;
    }

    /// <summary>
    /// DZ_1 LESSON
    /// </summary>
    /// <typeparam name="T">#</typeparam>
    /// <param name="array">#</param>
    /// <param name="newSize">#</param>
    public static void ResizeLesson<T>(ref T[] array, int newSize)
    {
        T[] newArray = new T[newSize];
        for (int i = 0; i < array.Length && i < newArray.Length; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    /// <summary>
    /// ДЗ №2 (insert)
    /// </summary>
    /// <param name="myArray">#</param>
    /// <param name="index">#</param>
    /// <param name="value">#</param>
    /// <returns>int[]</returns>
    public static ref int[] Rebuild(ref int[] myArray, int index, int value)
    {
        int res_num = (index > myArray.Length) ? index - myArray.Length : 1;
        Array.Resize(ref myArray, myArray.Length + res_num);
        switch (index)
        {
            case 0:
                for (int num_el = myArray.Length - 1; num_el > 0; num_el--)
                    myArray[num_el] = myArray[num_el - 1];
                myArray[0] = value;
                break;
            default:
                if (index < myArray.Length)
                {
                    for (int num_el = myArray.Length - 1; num_el > 0; num_el--)
                    {
                        myArray[num_el] = myArray[num_el - 1];
                        if (index == num_el)
                        {
                            myArray[index - 1] = value;
                            break;
                        }
                    }
                }
                else
                {
                    myArray[index - 1] = value;
                }
                break;
        }
        return ref myArray;
    }

    /// <summary>
    /// ДЗ №3
    /// </summary>
    /// <param name="myArray">#</param>
    /// <param name="index">#</param>
    /// <returns>int[]</returns>
    public static ref int[] DeleteElementArray(ref int[] myArray, int index)
    {
        int[] tmpArray = new int[myArray.Length];
        Array.Copy(myArray, tmpArray, tmpArray.Length);
        myArray = new int[myArray.Length - 1];
        if (index <= tmpArray.Length)
        {
            int ind = 0;
            for (int num_el = 0; num_el < tmpArray.Length; num_el++)
            {
                if (index - 1 != num_el)
                {
                    myArray[ind] = tmpArray[num_el];
                    ind++;
                }
            }
        }
        return ref myArray;
    }

    //При передаче данные просто копируются из одной переменной в другую
    //Сейчас мы не можем повлиять на значение переменной a в Main - они не зависят друг от друга
    //Если добавить слово ref то мы помещаем ссылку на саму переменную а не на ее значение и можем менять значение в Main
    //параметр помещается по ссылке а не по значению
    public static void Foo(ref int a)
    {
        a = -5;
    }

    /*
     * Передача аргументов по ссылке
     */
    public struct MyStruct
    {
        public int a;
        public double b;
        public float c;
    }

    /*
     * Передача аргументов по ссылке в класс
     */
    public class MyClass
    {
        public int a;
        public double b;
        public float c;
    }

    public static void Foos(ref MyStruct myStruct)
    {
        myStruct.a = -5;
    }

    public static void FooClass(MyClass myClass)
    {
        myClass.a = -5;
    }

    public static void FooArray(int[] myArr)
    {
        myArr[0] = -5;
    }

    public static void FooArrayClear(ref int[] myArr)
    {
        myArr = null;
    }

    public static ref int FooArrayReturn(int[] myArr)
    {
        return ref myArr[0];
    }

    /// <summary>
    /// ref - позволяет произвести действия над ссылкой а не над данными 
    /// </summary>
    static void Main()
    {
        int a = 2;
        Foo(ref a);

        MyStruct Mystruct = new MyStruct();
        MyClass myClass = new MyClass();
        int[] myArray = { 1, 4, 6 };

        Foos(ref Mystruct);

        FooClass(myClass);

        FooArray(myArray);

        FooArrayClear(ref myArray);

        Console.WriteLine(a);

        //Фишка Ссылочных локальных переменных 
        //Через слово ref присваиваем ссылку на переменную в массиве
        int[] myArr_2 = { 1, 2, 3 };
        ref int el = ref myArr_2[2];
        el = 6;
        Console.WriteLine(myArr_2[2]);

        ref int bq = ref FooArrayReturn(myArr_2);

        //ДЗ №1
        int[] dz_1 = { 4, 2 };
        string[] dz_1_2 = { "aaa", "vbvv" };
        Array.Resize(ref dz_1, 10);
        Resize(ref dz_1, 10);
        ResizeLesson(ref dz_1, 10);
        ResizeLesson(ref dz_1_2, 10);
        Console.WriteLine(dz_1[7]);

        //ДЗ №2
        int[] dz_2 = { 1, 2, 3, 2, 4, 5, 6 };

        Rebuild(ref dz_2, 0, 10);
        Console.WriteLine(dz_2[0]);

        //ДЗ №3
        int[] dz_3 = { 44, 33, 11, 4 };
        DeleteElementArray(ref dz_3, 1);
    }
}