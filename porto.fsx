import React, { useState, useEffect } from 'react';
import { Mail, Github, Linkedin, Send, Code, Bot, Zap, Tool, Lock, Menu, X } from 'lucide-react';

const Portfolio = () => {
  const [currentPage, setCurrentPage] = useState('home');
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [scrolled, setScrolled] = useState(false);

  useEffect(() => {
    const handleScroll = () => setScrolled(window.scrollY > 50);
    window.addEventListener('scroll', handleScroll);
    return () => window.removeEventListener('scroll', handleScroll);
  }, []);

  useEffect(() => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
    setIsMenuOpen(false);
  }, [currentPage]);

  const pages = [
    { id: 'home', label: 'الرئيسية' },
    { id: 'about', label: 'من أنا' },
    { id: 'skills', label: 'القدرات' },
    { id: 'services', label: 'الخدمات' },
    { id: 'coming', label: 'قريبًا' },
    { id: 'contact', label: 'تواصل' }
  ];

  // Navbar Component
  const Navbar = () => (
    <nav className={`navbar ${scrolled ? 'scrolled' : ''}`}>
      <div className="container nav-content">
        <div className="logo">Df</div>
        
        <button className="menu-toggle" onClick={() => setIsMenuOpen(!isMenuOpen)}>
          {isMenuOpen ? <X size={24} /> : <Menu size={24} />}
        </button>

        <div className={`nav-links ${isMenuOpen ? 'active' : ''}`}>
          {pages.map((page, i) => (
            <button
              key={page.id}
              onClick={() => setCurrentPage(page.id)}
              className={`nav-link ${currentPage === page.id ? 'active' : ''}`}
              style={{ animationDelay: `${i * 0.1}s` }}
            >
              {page.label}
            </button>
          ))}
        </div>
      </div>
    </nav>
  );

  // Home Page
  const HomePage = () => (
    <div className="page home-page">
      <div className="floating-shapes">
        <div className="shape shape-1"></div>
        <div className="shape shape-2"></div>
        <div className="shape shape-3"></div>
      </div>
      
      <div className="container hero-section">
        <div className="hero-content fade-in">
          <h1 className="hero-title">
            مرحبًا، أنا <span className="gradient-text">Df</span>
          </h1>
          <h2 className="hero-subtitle">
            مطوّر ويب وصانع أدوات ذكية
          </h2>
          <p className="hero-description">
            أبني مواقع حديثة، بوتات ذكية، وأتمتة تساعد الأفراد والأعمال على العمل بسرعة وفعالية
          </p>
          
          <div className="hero-buttons">
            <button className="btn btn-primary" onClick={() => setCurrentPage('about')}>
              من أنا؟
            </button>
            <button className="btn btn-secondary" onClick={() => setCurrentPage('services')}>
              خدماتي
            </button>
          </div>

          <div className="quick-links">
            {pages.slice(1, 5).map((page, i) => (
              <button
                key={page.id}
                className="quick-link glass-card"
                onClick={() => setCurrentPage(page.id)}
                style={{ animationDelay: `${0.6 + i * 0.1}s` }}
              >
                {page.label}
              </button>
            ))}
          </div>
        </div>
      </div>
    </div>
  );

  // About Page
  const AboutPage = () => (
    <div className="page about-page">
      <div className="container">
        <div className="page-header fade-in">
          <h1 className="page-title gradient-text">من هو Df؟</h1>
        </div>
        
        <div className="about-content">
          <div className="about-avatar fade-in" style={{ animationDelay: '0.2s' }}>
            <div className="avatar-circle">
              <div className="avatar-inner">Df</div>
            </div>
          </div>

          <div className="about-text">
            <div className="glass-card fade-in" style={{ animationDelay: '0.3s' }}>
              <p className="about-intro">
                مطور تقني يهتم ببناء حلول بسيطة وفعّالة. متخصص في تطوير الواجهات، صناعة البوتات، الأتمتة، واستخراج البيانات. أركز دائمًا على الجودة، البساطة، والنتيجة الفعلية.
              </p>
            </div>

            <div className="glass-card fade-in" style={{ animationDelay: '0.4s' }}>
              <h3 className="section-subtitle">منهجيتي في العمل</h3>
              <p>
                أؤمن أن أفضل الحلول هي التي تجمع بين الوضوح والقوة. أحب بناء أنظمة صغيرة لكنها مفيدة وذات تأثير مباشر.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );

  // Skills Page
  const SkillsPage = () => {
    const skills = [
      { title: 'تطوير واجهات Frontend', desc: 'واجهات عصرية وسريعة بتقنيات حديثة', icon: '💻' },
      { title: 'صناعة البوتات', desc: 'بوتات Telegram وDiscord بمختلف الوظائف', icon: '🤖' },
      { title: 'أنظمة الأتمتة', desc: 'ربط المهام والخدمات تلقائيًا', icon: '⚡' },
      { title: 'Web Scraping', desc: 'استخراج وتنظيم البيانات بدقة', icon: '🔍' },
      { title: 'أدوات مخصصة', desc: 'Mini Tools حسب احتياجك الفعلية', icon: '🛠️' },
      { title: 'تحسين UX/UI', desc: 'تجربة مستخدم سلسة ومريحة', icon: '🎨' },
      { title: 'Mini Systems', desc: 'حلول أعمال بسيطة وفعالة', icon: '📦' }
    ];

    return (
      <div className="page skills-page">
        <div className="container">
          <div className="page-header fade-in">
            <h1 className="page-title gradient-text">القدرات والمهارات</h1>
            <p className="page-subtitle">ما أستطيع تقديمه لك</p>
          </div>

          <div className="skills-grid">
            {skills.map((skill, i) => (
              <div
                key={i}
                className="skill-card glass-card fade-in"
                style={{ animationDelay: `${i * 0.1}s` }}
              >
                <div className="skill-icon">{skill.icon}</div>
                <h3 className="skill-title">{skill.title}</h3>
                <p className="skill-desc">{skill.desc}</p>
              </div>
            ))}
          </div>
        </div>
      </div>
    );
  };

  // Services Page
  const ServicesPage = () => {
    const services = [
      {
        icon: <Code size={32} />,
        title: 'مواقع الويب',
        desc: 'واجهات حديثة، سرعة عالية، تصميم مريح، أنيميشنات احترافية، وتحسين تجربة المستخدم',
        cases: ['مواقع شخصية', 'لاندنج صفحات', 'تطبيقات ويب']
      },
      {
        icon: <Bot size={32} />,
        title: 'البوتات',
        desc: 'تطوير بوتات Telegram وDiscord، مهام تلقائية، جلب البيانات، نشر المحتوى، إدارة الأنظمة',
        cases: ['بوتات خدمية', 'بوتات إدارية', 'بوتات تفاعلية']
      },
      {
        icon: <Zap size={32} />,
        title: 'الأتمتة',
        desc: 'أدوات تنفذ مهام متكررة، ربط الخدمات، استخراج وتنظيم البيانات، تحسين الوقت والجهد',
        cases: ['أتمتة المهام', 'جلب البيانات', 'معالجة تلقائية']
      },
      {
        icon: <Tool size={32} />,
        title: 'أدوات مخصصة',
        desc: 'تحويل أي فكرة صغيرة إلى أداة عملية تعمل فورًا، Mini Tools، أنظمة خفيفة وسريعة',
        cases: ['أدوات خاصة', 'سكريبتات مفيدة', 'حلول سريعة']
      }
    ];

    return (
      <div className="page services-page">
        <div className="container">
          <div className="page-header fade-in">
            <h1 className="page-title gradient-text">الخدمات</h1>
            <p className="page-subtitle">ماذا أقدم؟</p>
          </div>

          <div className="services-grid">
            {services.map((service, i) => (
              <div
                key={i}
                className="service-card glass-card fade-in"
                style={{ animationDelay: `${i * 0.15}s` }}
              >
                <div className="service-icon">{service.icon}</div>
                <h3 className="service-title">{service.title}</h3>
                <p className="service-desc">{service.desc}</p>
                <div className="service-cases">
                  {service.cases.map((c, idx) => (
                    <span key={idx} className="case-tag">{c}</span>
                  ))}
                </div>
              </div>
            ))}
          </div>
        </div>
      </div>
    );
  };

  // Coming Soon Page
  const ComingSoonPage = () => {
    const projects = [
      'مشروع سري 1',
      'مشروع سري 2',
      'مشروع سري 3',
      'مشروع سري 4',
      'مشروع سري 5',
      'مشروع سري 6'
    ];

    return (
      <div className="page coming-page">
        <div className="container">
          <div className="page-header fade-in">
            <h1 className="page-title gradient-text">المشاريع القادمة</h1>
            <p className="page-subtitle">جاري العمل على أشياء رائعة...</p>
          </div>

          <div className="coming-grid">
            {projects.map((project, i) => (
              <div
                key={i}
                className="coming-card glass-card fade-in pulse"
                style={{ animationDelay: `${i * 0.1}s` }}
              >
                <Lock size={40} className="lock-icon" />
                <h3>{project}</h3>
                <p className="status">قريبًا...</p>
              </div>
            ))}
          </div>
        </div>
      </div>
    );
  };

  // Contact Page
  const ContactPage = () => {
    const [formData, setFormData] = useState({ name: '', email: '', message: '' });

    const handleSubmit = (e) => {
      e.preventDefault();
      const { name, email, message } = formData;
      const subject = `رسالة من ${name}`;
      const body = `الاسم: ${name}%0D%0Aالبريد: ${email}%0D%0A%0D%0Aالرسالة:%0D%0A${message}`;
      window.location.href = `mailto:your@email.com?subject=${subject}&body=${body}`;
    };

    const socialLinks = [
      { icon: <Send size={24} />, label: 'Telegram', url: '#', color: '#0088cc' },
      { icon: <Mail size={24} />, label: 'Email', url: 'mailto:your@email.com', color: '#ea4335' },
      { icon: <Github size={24} />, label: 'GitHub', url: '#', color: '#333' },
      { icon: <Linkedin size={24} />, label: 'LinkedIn', url: '#', color: '#0077b5' }
    ];

    return (
      <div className="page contact-page">
        <div className="container">
          <div className="contact-split">
            <div className="contact-info fade-in">
              <h1 className="page-title gradient-text">تواصل معي</h1>
              <p className="contact-intro">
                جاهز للعمل على فكرتك القادمة. يمكنك التواصل معي بسهولة عبر الروابط التالية.
              </p>

              <div className="social-links">
                {socialLinks.map((link, i) => (
                  <a
                    key={i}
                    href={link.url}
                    className="social-link glass-card"
                    style={{ animationDelay: `${0.2 + i * 0.1}s` }}
                  >
                    <div className="social-icon" style={{ color: link.color }}>
                      {link.icon}
                    </div>
                    <span>{link.label}</span>
                  </a>
                ))}
              </div>
            </div>

            <div className="contact-form-wrapper fade-in" style={{ animationDelay: '0.3s' }}>
              <form className="contact-form glass-card" onSubmit={handleSubmit}>
                <div className="form-group">
                  <label>الاسم</label>
                  <input
                    type="text"
                    required
                    value={formData.name}
                    onChange={(e) => setFormData({...formData, name: e.target.value})}
                    placeholder="اسمك الكريم"
                  />
                </div>

                <div className="form-group">
                  <label>البريد الإلكتروني</label>
                  <input
                    type="email"
                    required
                    value={formData.email}
                    onChange={(e) => setFormData({...formData, email: e.target.value})}
                    placeholder="email@example.com"
                  />
                </div>

                <div className="form-group">
                  <label>الرسالة</label>
                  <textarea
                    required
                    rows="5"
                    value={formData.message}
                    onChange={(e) => setFormData({...formData, message: e.target.value})}
                    placeholder="اكتب رسالتك هنا..."
                  />
                </div>

                <button type="submit" className="btn btn-primary">
                  إرسال الرسالة
                </button>
              </form>
            </div>
          </div>
        </div>
      </div>
    );
  };

  // Footer
  const Footer = () => (
    <footer className="footer">
      <div className="container">
        <p>© 2024 Df Portfolio - Built with passion</p>
      </div>
    </footer>
  );

  const renderPage = () => {
    switch(currentPage) {
      case 'home': return <HomePage />;
      case 'about': return <AboutPage />;
      case 'skills': return <SkillsPage />;
      case 'services': return <ServicesPage />;
      case 'coming': return <ComingSoonPage />;
      case 'contact': return <ContactPage />;
      default: return <HomePage />;
    }
  };

  return (
    <div className="portfolio" dir="rtl">
      <Navbar />
      <main className="main-content">
        {renderPage()}
      </main>
      <Footer />

      <style>{`
        * {
          margin: 0;
          padding: 0;
          box-sizing: border-box;
        }

        :root {
          --bg-dark: #0a0a0f;
          --bg-card: rgba(20, 20, 35, 0.6);
          --purple-dark: #6b46c1;
          --purple-light: #9333ea;
          --blue-light: #3b82f6;
          --text-primary: #e2e8f0;
          --text-secondary: #94a3b8;
          --glass-bg: rgba(255, 255, 255, 0.05);
          --glass-border: rgba(255, 255, 255, 0.1);
        }

        body {
          font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
          background: var(--bg-dark);
          color: var(--text-primary);
          overflow-x: hidden;
          line-height: 1.6;
        }

        .portfolio {
          min-height: 100vh;
        }

        .container {
          max-width: 1200px;
          margin: 0 auto;
          padding: 0 24px;
        }

        /* Navbar */
        .navbar {
          position: fixed;
          top: 0;
          left: 0;
          right: 0;
          z-index: 1000;
          padding: 20px 0;
          transition: all 0.3s ease;
        }

        .navbar.scrolled {
          background: rgba(10, 10, 15, 0.8);
          backdrop-filter: blur(20px);
          border-bottom: 1px solid var(--glass-border);
          padding: 15px 0;
        }

        .nav-content {
          display: flex;
          justify-content: space-between;
          align-items: center;
        }

        .logo {
          font-size: 28px;
          font-weight: 700;
          background: linear-gradient(135deg, var(--purple-light), var(--blue-light));
          -webkit-background-clip: text;
          -webkit-text-fill-color: transparent;
          background-clip: text;
        }

        .menu-toggle {
          display: none;
          background: none;
          border: none;
          color: var(--text-primary);
          cursor: pointer;
          padding: 8px;
        }

        .nav-links {
          display: flex;
          gap: 8px;
        }

        .nav-link {
          background: none;
          border: none;
          color: var(--text-secondary);
          padding: 10px 20px;
          border-radius: 12px;
          cursor: pointer;
          transition: all 0.3s ease;
          font-size: 15px;
          font-weight: 500;
        }

        .nav-link:hover {
          color: var(--text-primary);
          background: var(--glass-bg);
        }

        .nav-link.active {
          color: var(--purple-light);
          background: rgba(147, 51, 234, 0.1);
        }

        /* Main Content */
        .main-content {
          padding-top: 80px;
          min-height: calc(100vh - 80px);
        }

        .page {
          min-height: calc(100vh - 160px);
          padding: 60px 0;
        }

        /* Glass Card */
        .glass-card {
          background: var(--glass-bg);
          backdrop-filter: blur(20px);
          border: 1px solid var(--glass-border);
          border-radius: 20px;
          padding: 32px;
          transition: all 0.4s ease;
        }

        .glass-card:hover {
          transform: translateY(-5px);
          border-color: rgba(147, 51, 234, 0.3);
          box-shadow: 0 20px 40px rgba(147, 51, 234, 0.1);
        }

        /* Home Page */
        .home-page {
          position: relative;
          display: flex;
          align-items: center;
          min-height: calc(100vh - 80px);
        }

        .floating-shapes {
          position: absolute;
          width: 100%;
          height: 100%;
          overflow: hidden;
          z-index: 0;
        }

        .shape {
          position: absolute;
          border-radius: 50%;
          filter: blur(60px);
          opacity: 0.15;
          animation: float 20s infinite ease-in-out;
        }

        .shape-1 {
          width: 400px;
          height: 400px;
          background: var(--purple-dark);
          top: 10%;
          left: 10%;
        }

        .shape-2 {
          width: 300px;
          height: 300px;
          background: var(--blue-light);
          bottom: 20%;
          right: 10%;
          animation-delay: -5s;
        }

        .shape-3 {
          width: 250px;
          height: 250px;
          background: var(--purple-light);
          top: 50%;
          right: 30%;
          animation-delay: -10s;
        }

        @keyframes float {
          0%, 100% { transform: translate(0, 0); }
          33% { transform: translate(30px, -30px); }
          66% { transform: translate(-20px, 20px); }
        }

        .hero-section {
          position: relative;
          z-index: 1;
          text-align: center;
        }

        .hero-content {
          max-width: 800px;
          margin: 0 auto;
        }

        .hero-title {
          font-size: 64px;
          font-weight: 800;
          margin-bottom: 16px;
          line-height: 1.2;
        }

        .gradient-text {
          background: linear-gradient(135deg, var(--purple-light), var(--blue-light));
          -webkit-background-clip: text;
          -webkit-text-fill-color: transparent;
          background-clip: text;
        }

        .hero-subtitle {
          font-size: 32px;
          font-weight: 600;
          color: var(--text-secondary);
          margin-bottom: 24px;
        }

        .hero-description {
          font-size: 18px;
          color: var(--text-secondary);
          margin-bottom: 40px;
          line-height: 1.8;
        }

        .hero-buttons {
          display: flex;
          gap: 16px;
          justify-content: center;
          margin-bottom: 60px;
        }

        .btn {
          padding: 14px 32px;
          border: none;
          border-radius: 12px;
          font-size: 16px;
          font-weight: 600;
          cursor: pointer;
          transition: all 0.3s ease;
        }

        .btn-primary {
          background: linear-gradient(135deg, var(--purple-light), var(--blue-light));
          color: white;
        }

        .btn-primary:hover {
          transform: translateY(-2px);
          box-shadow: 0 10px 30px rgba(147, 51, 234, 0.4);
        }

        .btn-secondary {
          background: var(--glass-bg);
          color: var(--text-primary);
          border: 1px solid var(--glass-border);
        }

        .btn-secondary:hover {
          background: rgba(255, 255, 255, 0.1);
          border-color: var(--purple-light);
        }

        .quick-links {
          display: flex;
          gap: 16px;
          justify-content: center;
          flex-wrap: wrap;
        }

        .quick-link {
 
