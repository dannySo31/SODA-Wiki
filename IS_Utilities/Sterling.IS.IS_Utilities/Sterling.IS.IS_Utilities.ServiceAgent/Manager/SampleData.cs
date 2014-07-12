using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Sterling.IS.Utilities.ServiceAgent.Entities;

namespace Sterling.IS.Utilities.ServiceAgent.Manager
{
    public class SampleData : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            new List<Owner>
            {
                new Owner{
                    FirstName="Ayette",
                    LastName="Ventura",
                    Email="mventura@sterlinginfosystems.com",
                    Pic="~/Images/pics/Ayette.jpg",
                    Title="Application Developer"
                },
                 new Owner{
                    FirstName="Marlon",
                    LastName="Ulang",
                    Email="mulang@sterlinginfosystems.com",
                    Pic="~/Images/pics/Marlon.jpg",
                    Title="Application Developer"
                },
                 new Owner{
                    FirstName="Sherwin",
                    LastName="Lopamia",
                    Email="slopamia@sterlinginfosystems.com",
                    Pic="~/Images/pics/Sherwin.jpg",
                    Title="Application Developer"
                },
                 new Owner{
                    FirstName="Danny",
                    LastName="So",
                    Email="dso@sterlinginfosystems.com",
                    Pic="~/Images/pics/dso.jpg",
                    Title="Application Developer"
                }
            }.ForEach(a => context.Owners.Add(a));
            new List<MenuItem>
            {
                new MenuItem{
                    Name="Applications",
                    Path="/"
                },
                new MenuItem{
                    Name="Developers",
                    Path="/Developers/"
                },
                new MenuItem{
                    Name="Tools",
                    Path="/Home/"
                }
            }.ForEach(a=> context.Menu.Add(a));
            new List<Utility>(){
               new Utility{
                   ID=1,
                   Name="eManager_GetFiles",
                   PartialViewName="_eManager_GetFiles",
                   ApplicationId=5
               },
               new Utility{
                   ID=2,
                   Name="Controller_1",
                   PartialViewName="_Controller_1",
                   ApplicationId=1
               },
               new Utility{
                   ID=3,
                   Name="Controller_2",
                   PartialViewName="_Controller_2",
                   ApplicationId=1
               }
           }.ForEach(a => context.Utilities.Add(a));

            

             new List<Application>{
                new Application{
                    ID=1,
                    Name="2.0 Controller",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                },
                new Application{
                    ID=2,
                    Name="Client Preferences",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                },
                 new Application{
                    ID=3,
                    Name="ExitCheck",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                },
                new Application{
                    ID=4,
                    Name="Legacy Controller",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                },
                new Application{
                    ID=5,
                    Name="eManager",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                },
                new Application{
                    ID=6,
                    Name="VDS",
                    Description="Lorem ipsum dolor sit amet, ex suavitate concludaturque eum, saperet principes at pro. Illud simul impetus vix id, in doming signiferumque per, an has eirmod melius vocibus. Amet simul his cu, te wisi audiam pri. Mei an oblique docendi argumentum, cum ei justo constituto liberavisse. Nam te inani ornatus omittantur, no usu labitur minimum assueverit. Cu persius oportere per, mea id movet oblique. At perpetua assentior expetendis mel. Eu sed nonumy docendi eligendi. Cu vix dicam nostrud feugiat, facilisis iracundia definitiones vel at. Sed vocent invenire consectetuer ea, ad vis fastidii deterruisset, id graeco patrioque quo. Sea cu malis labore eleifend."
                }
            }.ForEach(a => context.Apps.Add(a));

            // new List<ApplicationOwner>{
            //    new ApplicationOwner{
            //        ID=1,
            //        OwnerId=1,
            //        ApplicationID=1
                
            //    },
            //    new ApplicationOwner{
            //        ID=2,
            //        OwnerId=2,
            //        ApplicationID=2
                
            //    },
            //    new ApplicationOwner{
            //        ID=3,
            //        OwnerId=1,
            //        ApplicationID=2
                
            //    }
            //}.ForEach(a => context.OwnerMapper.Add(a));
        }
       
    }
}
