import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TenantComponent } from './tenant/tenant.component';
import { BuildingComponent } from './building/building.component';
import { UserComponent } from './user/user.component';
import { PaymentComponent } from './payment/payment.component';
import { ExpenditureComponent } from './expenditure/expenditure.component';
import { FaultComponent } from './fault/fault.component';

@NgModule({
  declarations: [
    AppComponent,
    TenantComponent,
    BuildingComponent,
    UserComponent,
    PaymentComponent,
    ExpenditureComponent,
    FaultComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
