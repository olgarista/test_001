**Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**

["hello", "2", "world", ":-)",  -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []

**Алгоритм решения:**

1. Создаются два массива одинаковой длины. 
2. Используется метод void, где в цикле for проверяется условие: длина элемента первого массива <= 3. Если проверка условия возвращает true, выполняется тело цикла - элемент первого массива заносится во второй массив. Затем переменная count увеличивается на 1 и вновь выполняется цикл for, в котором i увеличивается на 1. Цикл завершается, когда пробежались по всем элементам первого массива.
3. Печатаются первый и второй массивы.

*Блок-схема метода в файле task1.drawio.png.*

*Код программы в файле Program.cs*