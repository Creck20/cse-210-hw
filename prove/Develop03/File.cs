public class File{
    private string _scriptureString = "";
    public string GetScripture(){

        string[] lines = System.IO.File.ReadAllLines("Scripture.txt");

        for(int i=0; i < lines.Length; i++){
            _scriptureString = _scriptureString + lines[i] + "\n";
        }

        return _scriptureString;
    }
    public void ClearFile(){
        System.IO.File.WriteAllText("Scripture.txt", string.Empty);
    }
}