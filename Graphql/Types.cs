using GraphQL.Types;
using SQLSVR_WEBAPI.Models;

namespace SQLSVR_WEBAPI.Types
{
    public class PlayersType : ObjectGraphType<Players>
    {
        public PlayersType()
        {
            Field(x => x.PlayerId);
            Field(x => x.Name);
            Field(x => x.TeamId);
        }
    }
}