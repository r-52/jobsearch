import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: "console",
    loadChildren: () => import("./console/console-routing.module").then(x => x.ConsoleRoutingModule),
  },
  {
    path: "-",
    loadChildren: () => import("./frontend/frontend-routing.module").then(x => x.FrontendRoutingModule),
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
