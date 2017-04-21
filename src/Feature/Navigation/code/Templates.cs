namespace Sitecore.Feature.Navigation
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct NavigationRoot
    {
      public static readonly ID ID = new ID("{21B4ACFD-AE4F-4FB1-8552-4B2365BD498F}");
    }

    public struct Navigable
    {
      public static readonly ID ID = new ID("{C67E19ED-EC04-4712-AC15-BB75FBFA5E5D}");

      public struct Fields
      {
        public static readonly ID ShowInNavigation = new ID("{3EF1EFCE-CB53-4386-B729-A57D07481EC0}");
        public static readonly ID NavigationTitle = new ID("{52F7E0DD-1DD6-428E-9740-0490138AD0C1}");
        public static readonly ID ShowChildren = new ID("{B2CB7FA4-7471-4C0E-9D54-E7CD26B8F495}");
      }
    }

    public struct Link
    {
      public static readonly ID ID = new ID("{0C492CCF-2D5A-4887-A91D-5B6F7D15CA80}");

      public struct Fields
      {
        public static readonly ID Link = new ID("{71070BB3-C663-4F03-A2AE-69908B949611}");
      }
    }

    public struct LinkMenuItem
    {
      public static readonly ID ID = new ID("{FFE624B5-350B-4154-BE70-B42D809746E1}");

      public struct Fields
      {
        public static readonly ID Icon = new ID("{85964011-6208-4E72-9298-5D3F96DD9175}");
        public static readonly ID DividerBefore = new ID("{EF7E786A-FCF2-4A16-AAD2-CE963E400040}");
      }
    }
  }
}