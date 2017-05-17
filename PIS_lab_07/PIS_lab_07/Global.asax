<%@ Application Language="C#" %>
 
<script runat="server">
public override string GetVaryByCustomString(HttpContext context, string arg)
{
        // Проверить запрашиваемый тип кэширования
        if (arg == "origin")
        {
            // Определить текущий браузер
            string browserName;
            browserName = Context.Request.Browser.Browser;
            browserName += Context.Request.Browser.MajorVersion.ToString();

            // Указать, что эта строка должна применяться для варьирования кэша
            return browserName;
        }
        else
        {
            return base.GetVaryByCustomString(context, arg);
        }
}
</script>