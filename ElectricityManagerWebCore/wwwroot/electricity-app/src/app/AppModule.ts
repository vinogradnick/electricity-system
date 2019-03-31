import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { ElectrictyObjectComponent } from './electricty-object/electricty-object.component';
import { CustomersComponent } from './customers/customers.component';
import { RequestConstructorComponent } from './request-constructor/request-constructor.component';
import {MatToolbarModule } from '@angular/material/toolbar';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ElectrictyObjectComponent,
    CustomersComponent,
    RequestConstructorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
  ],
  exports:[
    MatToolbarModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
