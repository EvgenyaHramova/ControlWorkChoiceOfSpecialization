
#ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Алгоритм выполнения итогового задания:**
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если она выделена в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Описание алгоритма решения задачи**
* Пользователю  предлагается ввести количество элементов в одномерном массиве, инициализируется переменная m, опрелеляющая в дальнейшем размер массива strArray[].
* Иннициализируестя массив с количеством элементов, введенных пользователем: strArray[m].
* С помощью медода StringArray создается массив строк. В данном методе пользователю предлагается ввести значения элементов массива и введенные значения выводятся в виде массива для наглядности на печать.
* Далее пользователю предлагается ввести предельное количество символов, которое может содержаться  в элементе нового массива. Создается переменная countSimbol.
* Далее создается переменная count, с помощью которой будем определять наличие либо отсутствие в введенных элементах строк в массиве элементов с количеством символов равных или менее значения countSimbol.
Если в массиве все элементы с количеством символов больше значения countSimbol, то для пользователя выводится тект об отсутствии таких элементов в массиве, иначе програме переходит в метод NewStringArray.
* В методе NewStringArray иннициализируем новый массив strArray1 размерностью, равной массиву strArray, и переменную j.
С помощью цикла for осуществляем проверку массива strArray для присваивания элементам массива strArray1, значений с количеством символов равных или менее значения countSimbol и осуществляем подстчет количества таких элементов с помощью переменной j.
Далее создаем новый массив newStrArray с количеством элементов j.
С помощью цикла присваиваем элементам данного массива  значения из массива strArray1, не равные "".
Далее выводим искомый массив newStrArray на печать, который содержит элементы с количеством символов менее или равных значению countSimbol, введенному пользователем. 

*Программа по решению задачи находится в папке Zadacha*

*Блок-схема с алгоритмом метода NewStringArray из программы представлена в файле АлгоритмContrWork.jpg*
