1) ----------------------------------------------------------------------------------------------
private void set_mode(bool mod)

{
 if(mod)
	ModTrue();
 else
	ModFalse();
}

private void ModTrue()
{
	label1.Enabled=true;
	button1.Enabled=true;
	button2.Enabled=true;
	button3.Enabled=false;
	button4.Enabled=false;
}

private void ModFalse()
{
    label1.Enabled = false;
    button1.Enabled = false;
    button2.Enabled = false;
    button3.Enabled = true;
    button4.Enabled = true;
}

2) ----------------------------------------------------------------------------------------------
return m_driverStatusNames[driver.Status];
3) ----------------------------------------------------------------------------------------------
uint i;
…
if (i<10)
{
...
}
4) ----------------------------------------------------------------------------------------------
string destination = "";
for (int i = 0; i< 13; i++)
 destination += source[i];
5) ----------------------------------------------------------------------------------------------
 Bool IsNumber(string str)
{
    int result;
    return Int32.TryParse(str, out result);
6) ----------------------------------------------------------------------------------------------
    void RefactoringFunctionForCheckDirectories()
    {
        foreach (DirectoryInfo dir in dirs.GetDirectories())
        {
            CheckDirectory(dir);
        }
    }


    void CheckDirectory(DirectoryInfo dir)
    {
        CreateFolder();
        SendFolderName();
    }

    void CreateFolder()
    {
        stream.Write(
        new byte[] { (byte)NetworkMessage.MakeDir },
        0, 1
        );
        stream.Read(
        new byte[1],
        0, 1
        );
        stream.Write(
        BitConverter.GetBytes(
        Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length
        ),
        0, 4
        );

        stream.Write(
        Encoding.UTF8.GetBytes(
        SubFolder.Replace('\\', '/') +
        dir.Name.Replace('\\', '/')
        ),
        0, Encoding.UTF8.GetBytes(
        SubFolder.Replace('\\', '/') +
        dir.Name.Replace('\\', '/')
        ).Length
        );
    }


    void SendFolderName()
    {
        stream.Read(new byte[1], 0, 1);
    }
7) ----------------------------------------------------------------------------------------------
    String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
8) ----------------------------------------------------------------------------------------------
    DateTime dt = DateTime.Now;
    char pad = '0';
    Console.WriteLine("--" + dt.Hour.ToString().PadLeft(2, pad) + ":" + dt.Minute.ToString().PadLeft(2, pad) + ":" + dt.Second.ToString().PadLeft(2, pad) + "--");
9) ----------------------------------------------------------------------------------------------
    return (Counter % 2 == 0);
    10) ----------------------------------------------------------------------------------------------
    if (Connected == 0))
	rez = setup();
    return;
    11) ----------------------------------------------------------------------------------------------
    List<int> arr = new List<int>();

    for (int i = 0; i < arr.Count; i++)
    {
        if (arr[i] > 100)
        {
            arr.Remove(arr[i--]);
        }
    }
    12) ----------------------------------------------------------------------------------------------
    var ids = form.Keys;
    if (ids.Length != 1) { throw Exception; }
    13) ----------------------------------------------------------------------------------------------
    string[] nameParts = customer.Name.Split(' ');
    string firstName = nameParts[0];
    string lastName = nameParts[1];
    14) ----------------------------------------------------------------------------------------------
    string[] tmp = sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
    sourceID = Int32.Parse(tmp[0]);
    15) ----------------------------------------------------------------------------------------------
    public string generateEMail()
    {
        string res;
        res = PersonName;
        res = res.Replace(' ', '.');
        if (res.Length > 20)
        {
            res = res.Substring(0, 19);
        }
        res += "@domain.ua";
        return res;
    }
    16) ----------------------------------------------------------------------------------------------
    foreach (string id in sourceIDs.Split(new char[] { ',' },
StringSplitOptions.RemoveEmptyEntries))
    {
        sourceId = Convert.ToInt32(id);
        break;
    }
    17) ----------------------------------------------------------------------------------------------
    string GetTextDiv2(string text)
    {
        int mid = text.Length / 2;
        int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
        int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
        if (r - mid > mid - l) // to left is closer
            mid = l;
        else mid = r;
        if (mid == 5000) return "&nbsp" + text;
        return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" +
       text.Substring(mid, text.Length - mid);
    }

mid 5000
    18) ----------------------------------------------------------------------------------------------
    private static readonly char SPECIFIER = "$"[0];
private static readonly char DELIMITER = ":"[0];
private static readonly char[] DELIMITER_ARRAY = { DELIMITER };
19) ----------------------------------------------------------------------------------------------
string mailTo = CreateMailto();

string CreateMailto()
{
    if (MailtoCondition())
    {
        return Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString();
    }
    else
    {
        return Config.GetSetting("AdminNotifications_EmailAddress");
    }
}

bool MailtoCondition()
{
    return (
    (Config.GetSetting("AdminNotifications_EmailAddress") == null) ||
    (Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0)
    );
}
20) ----------------------------------------------------------------------------------------------
public bool CheckPath(string path)
{
    int n = 0;

    //Проверяем наличие нужных папок; 
    foreach (string neededDir in NEEDED_DIRECTORIES_ARRAY)
    {
        if (Directory.Exists(path + neededDir)) n++;
        else
            return false;
    }

    //Проверяем наличие нужных файлов 
    foreach (string neededFile in NEEDED_FILES_ARRAY)
    {
        if (File.Exists(path + neededfile)) n++;
        else
            return false;
    }
    return true;
    //Если указанная папка содержит все, что нужно 
    //if (n == NEEDED_COUNT)
    //{
    //    return true;
    //}
    //return false;
}
21) ----------------------------------------------------------------------------------------------
txtContacts.Text = "";
foreach (string contact in contacts)
{
txtContacts.Text += contact +";";
//txtContacts.Text += ";";
}
    22) ----------------------------------------------------------------------------------------------
    Game1.clou = !Game1.clou;



