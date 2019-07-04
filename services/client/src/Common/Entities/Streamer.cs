using System;

namespace GrapeApe.Client.Common {

  public partial class Streamer {

    public Guid Id { get; set; }

    public string Login { get;set; }

    public Constants.Enums.AccountStatus AccountStatus { get; set; }

    public DateTime DateCreated { get; set; }

  }
}
