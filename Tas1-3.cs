//Выделение метода 
//до
//(длинный метод разбиваем на под-методы)
//1
void PrintUserInfo(decimal amount)
 { 
PrintParentInfo();
Console.WriteLine(string.Format("имя: {0}", name);
Console.WriteLine(string.Format("возраст: {0}", age);
Console.WriteLine(string.Format("кол-во: {0}", amount);
 }

//2
//Встраивание метода
//до
int GetPoints()
 {
 return HasMaxSum() ? decimal.One : decimal.Zero;
 } 
bool HasMaxSum()
 {
 return summ >= maxSumm;
 }

//3
//Встраивание временной переменной
//до (лишний промежуточный код)
decimal cost = order.GetCost();
return cost > 1000;

//4
// Замена временной переменной вызовом метода
//до 
decimal MethodA()
 {
 decimal summ = amount * cost;
 if(summ > 1000)
 {
 do something return summ * 10;
 }
 return 0;
 }
 decimal MethodB()
{
do something decimal summ = amount * cost;
return summ != 0 ? summ * 100 : 1; 
}

//5
//Удаление присвоений параметрам (лучше воспользоваться временной переменной) Методы не должны менять значения входящих параметров, если это явно не указано/
//до 
int Discount(int amount, bool useDefaultDiscount, DateTime date)
 {
 if(amount == 0 && useDefaultDiscount)
 {
 amount = 10;
 }
 return amount;
 }

//6
//Введение поясняющей переменной (упрощается чтение и понимание кода)
//до 
if(VisualItems.ColumnCount == FocusedCell.X && (key == Keys.Alt | Keys.Shift) && WasInitialized() && (resize > 0))
{ 
 do something 
}
//конец первого задания


//7
//Декомпозиция условного оператора
//до
if (date.before (SUMMER.START) || date.after(SUMMER.END)){
charge = quantity * _winterRate + _wlnterServiceCharge;
else charge = quantity * _summerRate;
}

//8
//Консолидация дублирующихся условных фрагментов
//до (Поскольку метод send выполняется в любом случае, следует вынести его из условного оператора)
if (isSpecialDealO)
 {
total = price * 0 95;
send(); 
else 
{ 
total = price * 0 98;
send(); 
}

//9
//Консолидация условного выражения
//до (Здесь ряд условных операторов, возвращающих одинаковый результат. Для кода в такой последовательности проверки эквивалентны предложению с операцией « или»)
double disabilityAmount()
 {
 if (_semonty < 2) return 0
 if (_monthsDisabled > 12) return 0
 if (_isPartTime) return 0 // вычислить сумму оплаты по нетрудоспособности
}

//10
//Удаление управляющего флага
//до (Это фрагмент, в котором переменной found присваивается значение true)
void checkSecurity(String[] people) 
{ 
boolean found = false;
for (int i=0, l < people.length, i++) 
{ 
if (found) {
if (people[i] equals ("Don")){
sendAlert();
found = true;
 }
 if (people[i] equals ("John")){
sendAlert();
found = true;
}
}
}
}

//конец второго задания

//11
//Подъем поля, метода
//до (Подклассы имеют методы, которые делают схожую работу, значит нужно сделать методы идентичными, а затем переместить их в суперкласс.
class Animal
{
public:
	virtual void vote();
}

class Dog : public Animal
{
public:
	void vote() override;
	void getStatusDog();
	
private:
	std::string status_;
}

class Bird : public Animal
{
public:
	void vote() override;
	void getStatusBird();
	
private:
	std::string status_;
}

//12
//Спуск поля, метода
//до (перемащаем поля в подклассы)
class Unit
{
public:
	void getFuel();
	...
	
private:
	int fuel_;
	...
}

class Solider : public Unit
{
	...
}

class Tank : public Unit
{
	...
}
//конец третьего задания
