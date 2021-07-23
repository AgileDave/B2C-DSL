
using System.Collections.Generic;
using agileways.b2c.builder.models.common;
using agileways.b2c.builder.models.techProfile;

namespace agileways.b2c.builder.library.common.techProfiles
{

    public static class BaseTpEngineTechnicalProfiles
    {
        public static TechnicalProfile TpEngine
        {
            get => new TechnicalProfile
            {
                Id = "TpEngine_c3bd4fe2-1775-4013-b91d-35f16d377d13",
                DisplayName = "Trustframework Policy Engine Default Technical Profile",
                Protocol = new TechnicalProfileProtocol { Name = ProtocolName.None },
                Metadata = new List<metadataItem> {
                    new metadataItem { Key = "url", Value = "{service:te}" }
                }
            };
        }
    }
}