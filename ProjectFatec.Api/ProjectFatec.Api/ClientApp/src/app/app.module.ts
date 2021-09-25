import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BreakPointRegistry, FlexLayoutModule, FlexStyleBuilder, LayoutAlignStyleBuilder, LayoutStyleBuilder, PrintHook, StylesheetMap, StyleUtils } from '@angular/flex-layout';
import { MatButtonModule, MatDialogModule, MatExpansionModule, MatIconModule, MatListModule, MatSidenavModule, MatTableModule, MatToolbarModule } from '@angular/material';
import { ToastrModule } from 'ngx-toastr';
import { NgxMaskModule } from 'ngx-mask';
import { CommonModule } from '@angular/common';
import { MaterialModule } from './modules/material-module/material.module';
import { HeaderComponent } from './layout/header/header.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
  ],
  imports: [
    BrowserModule,
    MaterialModule,
    CommonModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    MatTableModule,
    FormsModule,
    HttpClientModule,
    FlexLayoutModule,
    MatDialogModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatExpansionModule,
    ToastrModule.forRoot(),
    NgxMaskModule.forRoot(),

  ],
  providers: [
    PrintHook,
    StyleUtils,
    StyleSheet,
    StylesheetMap,
    LayoutAlignStyleBuilder,
    LayoutStyleBuilder,
    FlexStyleBuilder,
    BreakPointRegistry
  ],
  exports: [
    AppComponent,
  ],
  bootstrap: [AppComponent],
  entryComponents: []
})
export class AppModule { }
