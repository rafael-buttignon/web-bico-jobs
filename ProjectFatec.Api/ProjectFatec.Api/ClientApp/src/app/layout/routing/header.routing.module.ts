import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AboutComponent } from "../about/about.component";
import { HowToWorkComponent } from "../how-to-work/how-to-work.component";
import { LandingpageComponent } from "../landingpage/landingpage.component";

const routes: Routes = [
    {
        path: '',
        pathMatch: 'full',
        redirectTo: 'inicio'
    },
    {
        path: 'inicio',
        component: LandingpageComponent,
    },
    {
      path: 'como-funciona',
      component: HowToWorkComponent
    },
    {
    path: '**',
    component: AboutComponent
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [
        RouterModule
    ]
})
export class HeaderRoutingModule { }
