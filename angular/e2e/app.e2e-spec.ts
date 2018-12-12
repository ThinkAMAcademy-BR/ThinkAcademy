import { ThinkAcademyTemplatePage } from './app.po';

describe('ThinkAcademy App', function() {
  let page: ThinkAcademyTemplatePage;

  beforeEach(() => {
    page = new ThinkAcademyTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
