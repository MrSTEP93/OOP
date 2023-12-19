# ООП
Проходя модуль ООП и тему Наследование, решил немного углубиться в эту тему и расширил учебный пример классов Car и HybridCar
* Перегрузил конструкторы классов, вызывая один из другого через ключевое слово this
* Сделал для метода Move тип возвращаемого значения bool, чтобы проверять успешность езды
* Переопределил метод Move класса HybridCar для того, чтобы использовать логику базового класса, дополнив её собственной логикой класса-наследника
* Ну и самое большое изменение: кроме вида топлива, добавил в класс-наследник информацию о количестве каждого вида топлива (Словарь InternalFuelAmount).
  Соответственно, количество того топлива, которое выбирается текущим, берется из словаря записывается в поле FuelAmount, по которому мы проверяем возможность двигаться дальше,
  а после движения (метод Move) значение FuelAmount записывается обратно в словарь, чтобы вести корректный учет.

  Да, может быть излишне использовать словарь всего для двух пар, но это первое что пришло в голову, и менять его я не стал. 
Может, посоветуете, как можно сделать лучше и рациональнее. **Собственно, это был первый вопрос.**

## Второй вопрос касается метода NoFuel

Цель: я хотел, что бы при выполнении базового метода Move выводилось разное сообщение для разных типов машин. 
Собственно, я создал метод NoFuel для того, чтобы скрыть его реализацию в базовом классе посредством реализации в производном. 
Я надеялся на то, что при окончании топлива в HybridCar будет выдано сообщение, определенное для этого класса. Да, надеяться было глупо, этого действительно не происходит, ведь метод Move выполняется в базовом классе. Стало быть, здесь не получится реализовать эту задумку, надо пересматривать логику работы базового Move. Но мне кажется, что я буду изобретать велосипед, пытаясь переработать эту логику, ведь если FuelAmount == 0, то мы не едем, какие тут еще варианты? =)) Подскажите, **может есть какие-то сравнительно простые решения для этой задачи**, чтобы не лезть в дебри? А если подобное будет разбираться дальше по курсу, то скажите, чтобы я не спешил)) 

Ну и в целом, хотелось бы получить обратную связь по этому проекту, что можно улучшить и на что обратить внимание. Мой ник в пачке  **shatalov.ag**

*Благодарю за внимание!*
