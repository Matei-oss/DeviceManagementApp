import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login/login-page/login-page.component';
import { LoginModule } from './login/login.module';
import { LoginPageGuard } from './shared/guards/login-page.guard';

const routes: Routes = [
  {
    path: 'login',
    canActivate: [LoginPageGuard],
    loadChildren: () => import('./login/login.module').then(m => m.LoginModule)
  },
  {
    path: 'device',
    loadChildren: () => import('./device/device.module').then(m => m.DeviceModule)
  },
  {
    path: '',
    redirectTo: '/login',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
