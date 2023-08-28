import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TempratureConverterComponent } from './temprature-converter.component';

describe('TempratureConverterComponent', () => {
  let component: TempratureConverterComponent;
  let fixture: ComponentFixture<TempratureConverterComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TempratureConverterComponent]
    });
    fixture = TestBed.createComponent(TempratureConverterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
