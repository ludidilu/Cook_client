﻿using UnityEditor;

public class CreateCsvDatTool
{
    [MenuItem("Create csv.dat/Do")]
    public static void Start()
    {
        ResourceLoader.LoadConfigLocal();

        ResourceLoader.LoadTablesLocal();

        CreateCsvDat.Start("/Scripts/sds/fix/");
    }
}
