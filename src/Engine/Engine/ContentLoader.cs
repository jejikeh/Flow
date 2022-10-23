using SFML.Graphics;

namespace Engine;

public class ContentLoader
{
    private Game _game;

    public ContentLoader(Game game)
    {
        _game = game;
    }
    
    public static Texture InitTexture(string filePath)
    {
        return new Texture("./Content/" + filePath);
    }

    public void InitContent()
    {
        if (!Directory.Exists("./Content"))
            Directory.CreateDirectory("./Content");
        
        CopyFilesRecursively($"../../../../../{_game.Config.Title}/{_game.Config.PathToContent}","./Content");
    }
    
    private static void CopyFilesRecursively(string sourcePath, string targetPath)
    {
        //Now Create all of the directories
        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
        {
            if(!Directory.Exists(dirPath.Replace(sourcePath, targetPath)))
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
        }

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",SearchOption.AllDirectories))
        {
            if(!File.Exists(newPath.Replace(sourcePath, targetPath)))
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
        }
    }
}