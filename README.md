# Итоговая работа

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

_Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

## Описание решения задачи.

Основная проблема заключалась в попытке сделать заполняемый массив,без предварительного ввода размера массива.
Для решения была использована копия массива, которая передавала элементы массива, которые ввел пользователь, в основной массив. Это решало проблему отсутвия изначального размера массива, с учетом условия задачи.
Вторая часть задачи была решена аналогичным способом.
Попытка создания функцию для сокращения кода была неудачной, из-за того, что эелементы массива всегда выходили за рамки его размера, решить эту проблему не удалось.
