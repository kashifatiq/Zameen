if not exists (select  * from AppSettings where AppSettingName = 'DbVersion')
begin
INSERT INTO AppSettings
                         (AppSettingName, AppSettingValue,Description)
VALUES        ('DbVersion','1','')
end