using Microsoft.OData.Client;
namespace AIO.IDOS3.Data.Entity
{
    [Key("ID")]
    public partial class vLogin : BaseEntityType, IvLogin
    {
    }
}
