//Выделение метода 
//после
//(длинный метод разбиваем на под-методы)
//1
void PrintUserInfo(decimal amount)
{
PrintParentInfo();
PrintUserDetails(decimal amount); 
} 

void PrintUserDetails(decimal amount)
{ 
Console.WriteLine(string.Format("имя: {0}", name);
Console.WriteLine(string.Format("возраст: {0}", age);
Console.WriteLine(string.Format("кол-во: {0}", amount);
}


//2
//Встраивание метода
//после
int GetPoints()
 {
 return summ >= maxSumm ? decimal.One : decimal.Zero;
 }


//3
//Встраивание временной переменной
//после (лишний промежуточный код)
return order.GetCost() > 1000;


//4
// Замена временной переменной вызовом метода
//после  (преобразуем выражение в метод)
decimal MethodA()
 {
 if(GetSumm() > 1000)
 {
 do something return GetSumm() * 10;
 }
 return 0;
 } 
decimal MethodB()
 {
 do something return GetSumm() != 0 ? GetSumm() * 100 : 1;
 }
 decimal GetSumm() 
{
 return amount * cost;
 }


//5
//Удаление присвоений параметрам (лучше воспользоваться временной переменной) Методы не должны менять значения входящих параметров, если это явно не указано/
//после (помещаем результат выражения или его части во временную переменную) 
int Discount(int amount, bool useDefaultDiscount, DateTime date)
 {
 int result = amount; 
if(amount == 0 && useDefaultDiscount)
 {
 result = 10;
 }
 return result;
 }

//6
//Введение поясняющей переменной (упрощается чтение и понимание кода) 
//после (Выделяем методы из условия, части «then» и частей «else»)
bool isLastFocusedColumn = VisualItems.ColumnCount == FocusedCell.X;
 bool altShiftPressed = (key == Keys.Alt | Keys.Shift);
 bool wasResized = resize > 0;
 if(isLastFocusedColumn && altShiftPressed && WasInitialized() && wasResized)
 { 
 do something 
}

//конец первого задания


//7
//Декомпозиция условного оператора
//после 
if (notSummer(date)) charge = winterCharge(quantity); 
else charge = summerCharge (quantity);

//8
//Консолидация дублирующихся условных фрагментов
//после (Поскольку метод send выполняется в любом случае, следует вынести его из условного оператора) 
if (isSpecialDealO) total = price * 0 95;
else total = price * 0 98;
send();

//9
//Консолидация условного выражения
//после (Здесь ряд условных операторов, возвращающих одинаковый результат. Для кода в такой последовательности проверки эквивалентны предложению с операцией « или»)
double disabilityAmount()
 { 
if (_semonty < 2||_monthsDisabled > 12||_isPartTime) return 0 // вычислить сумму оплаты по нетрудоспособности
}

//10
//Удаление управляющего флага
//после (Это фрагмент, в котором переменной found присваивается значение true)
void checkSecunty(String[] people) 
{
 boolean found = false;
for (int i=0 l < people length i++) 
{
    if (found) 
    {
        if (people[i] equals ( "Don" ))
        {
            sendAlert() break > if (people[i] equals ( "John" ))
                { 
                    sendAlertO found = true;
            }
        }
    }
}

//конец второго задания

//11
//Подъем поля, метода
//после (Подклассы имеют методы, которые делают схожую работу, значит нужно сделать методы идентичными, а затем переместить их в суперкласс. 
class Animal
{
public:
	virtual void vote();
	void getStatus();
	
private:
	std::string status_;
}

class Dog : public Animal
{
public:
	void vote() override;
	void getStatus() override;
}

class Bird : public Animal
{
public:
	void vote() override;
	void getStatus() override;
}

//12
//Спуск поля, метода
//после (перемащаем поля в подклассы)
class Unit
{
public:
	...
	
private:
	...
}

class Solider : public Unit
{
	...
}

class Tank : public Unit
{
public:
	void getFuel();

private:
	int fuel_;
}
//конец третьего задания