import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginService } from './services/login.service';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../app-routing.module';
import { AngularMaterialModule } from '../angular-material.module';
import { AppPageComponent } from './app-page/app-page.component';



@NgModule({
  declarations: [
    SidebarComponent,
    AppPageComponent
  ],
  imports: [
    AngularMaterialModule,
    CommonModule,
    // BrowserModule
    
    
  ],
  exports:[
    SidebarComponent,
    AngularMaterialModule,
    AppPageComponent
  ],
  providers: [
    LoginService
  ]
})
export class SharedModule { }
