//��������� ������ 
//�����
//(������� ����� ��������� �� ���-������)
//1
void PrintUserInfo(decimal amount)
{
PrintParentInfo();
PrintUserDetails(decimal amount); 
} 

void PrintUserDetails(decimal amount)
{ 
Console.WriteLine(string.Format("���: {0}", name);
Console.WriteLine(string.Format("�������: {0}", age);
Console.WriteLine(string.Format("���-��: {0}", amount);
}


//2
//����������� ������
//�����
int GetPoints()
 {
 return summ >= maxSumm ? decimal.One : decimal.Zero;
 }


//3
//����������� ��������� ����������
//����� (������ ������������� ���)
return order.GetCost() > 1000;


//4
// ������ ��������� ���������� ������� ������
//�����  (����������� ��������� � �����)
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
//�������� ���������� ���������� (����� ��������������� ��������� ����������) ������ �� ������ ������ �������� �������� ����������, ���� ��� ���� �� �������/
//����� (�������� ��������� ��������� ��� ��� ����� �� ��������� ����������) 
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
//�������� ���������� ���������� (���������� ������ � ��������� ����) 
//����� (�������� ������ �� �������, ����� �then� � ������ �else�)
bool isLastFocusedColumn = VisualItems.ColumnCount == FocusedCell.X;
 bool altShiftPressed = (key == Keys.Alt | Keys.Shift);
 bool wasResized = resize > 0;
 if(isLastFocusedColumn && altShiftPressed && WasInitialized() && wasResized)
 { 
 do something 
}

//����� ������� �������


//7
//������������ ��������� ���������
//����� 
if (notSummer(date)) charge = winterCharge(quantity); 
else charge = summerCharge (quantity);

//8
//������������ ������������� �������� ����������
//����� (��������� ����� send ����������� � ����� ������, ������� ������� ��� �� ��������� ���������) 
if (isSpecialDealO) total = price * 0 95;
else total = price * 0 98;
send();

//9
//������������ ��������� ���������
//����� (����� ��� �������� ����������, ������������ ���������� ���������. ��� ���� � ����� ������������������ �������� ������������ ����������� � ��������� � ���)
double disabilityAmount()
 { 
if (_semonty < 2||_monthsDisabled > 12||_isPartTime) return 0 // ��������� ����� ������ �� ������������������
}

//10
//�������� ������������ �����
//����� (��� ��������, � ������� ���������� found ������������� �������� true)
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

//����� ������� �������

//11
//������ ����, ������
//����� (��������� ����� ������, ������� ������ ������ ������, ������ ����� ������� ������ �����������, � ����� ����������� �� � ����������. 
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
//����� ����, ������
//����� (���������� ���� � ���������)
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
//����� �������� �������