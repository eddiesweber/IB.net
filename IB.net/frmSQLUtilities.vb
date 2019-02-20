Public Class frmSQLUtilities
    Private Sub cmdBackupTransactionLogs_Click(sender As Object, e As EventArgs) Handles cmdBackupTransactionLogs.Click

        Dim strSQL As String = ""

        strSQL = "BACKUP Log [TESTIBPortland] TO  DISK = N'C:\MSSQL\Backup\TESTIBPortland.trn' "
        strSQL = strSQL & " WITH NOFORMAT, NOINIT, "
        strSQL = strSQL & "NAME = N'TESTIBPortland', SKIP, REWIND, NOUNLOAD,  STATS = 10"

        'BACKUP Log [IBLA] TO  DISK = N'D:\MSSQL\Backup\IBLA_backup_2019_02_13_120711_7761884.trn' WITH NOFORMAT, NOINIT,  NAME = N'IBLA_backup_2019_02_13_120711_7761884', SKIP, REWIND, NOUNLOAD,  STATS = 10
        'GO
        'BACKUP Log [IBPortland] TO  DISK = N'D:\MSSQL\Backup\IBPortland_backup_2019_02_13_120711_7911884.trn' WITH NOFORMAT, NOINIT,  NAME = N'IBPortland_backup_2019_02_13_120711_7911884', SKIP, REWIND, NOUNLOAD,  STATS = 10
        'GO
        'BACKUP Log [IBSanf] TO  DISK = N'D:\MSSQL\Backup\IBSanf_backup_2019_02_13_120711_8011884.trn' WITH NOFORMAT, NOINIT,  NAME = N'IBSanf_backup_2019_02_13_120711_8011884', SKIP, REWIND, NOUNLOAD,  STATS = 10
        'GO
        'BACKUP Log [IBSea] TO  DISK = N'D:\MSSQL\Backup\IBSea_backup_2019_02_13_120711_8161884.trn' WITH NOFORMAT, NOINIT,  NAME = N'IBSea_backup_2019_02_13_120711_8161884', SKIP, REWIND, NOUNLOAD,  STATS = 10
        'GO
        'BACKUP Log [TESTIBPortland] TO  DISK = N'D:\MSSQL\Backup\TESTIBPortland_backup_2019_02_13_120711_8261884.trn' WITH NOFORMAT, NOINIT,  NAME = N'TESTIBPortland_backup_2019_02_13_120711_8261884', SKIP, REWIND, NOUNLOAD,  STATS = 10
        'GO
        'BACKUP Log [TESTIBSea] TO  DISK = N'D:\MSSQL\Backup\TESTIBSea_backup_2019_02_13_120711_8311884.trn' WITH NOFORMAT, NOINIT,  NAME = N'TESTIBSea_backup_2019_02_13_120711_8311884', SKIP, REWIND, NOUNLOAD,  STATS = 10
    End Sub
End Class