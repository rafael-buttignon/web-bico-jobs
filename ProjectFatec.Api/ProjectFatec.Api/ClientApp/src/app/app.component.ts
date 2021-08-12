import { SampleService } from './../share/apiService/sample.service';
import { environment } from './../environments/environment';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'app';
  client_env_name: string = environment.env_name;
  server_env_name: string = null;

  constructor(private SampleService: SampleService) {

  }
  ngOnInit(): void {
    this.SampleService.getAppSettings().subscribe(
      (value: string) => this.server_env_name = value,
      (error: any) => console.error("error", error)
    )
  }
}
