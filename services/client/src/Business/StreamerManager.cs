using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using GrapeApe.Client.Common;
using GrapeApe.Client.Data;

namespace GrapeApe.Client.Business {

  public class StreamerManager {

    private readonly ClientDbContext _currentContext;

    public StreamerManager(ClientDbContext dbContext) {
      _currentContext = dbContext;
    }

    public async Task<Streamer> GetStreamerById(string id) {
      if (Guid.TryParse(id, out Guid idGuid)) {
        Streamer streamer = await _currentContext.Streamers.FindAsync(idGuid);
        return streamer;
      }

      return null;
    }

    public async Task<Streamer> GetStreamerByLogin(string login) {
      if (!string.IsNullOrEmpty(login)) {
        Streamer streamer = await _currentContext.Streamers.FirstOrDefaultAsync(f =>
                                                              f.Login.Equals(
                                                                login,
                                                                StringComparison.InvariantCultureIgnoreCase));
        return streamer;
      }

      return null;
    }
  }
}
