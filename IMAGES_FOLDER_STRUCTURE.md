# Image Directory Structure

## Recommended Folder Organization for wwwroot/images/

```
wwwroot/
?
??? images/
?   ??? gallery/
?   ?   ??? equipment/
?   ?   ?   ??? gas-pump-1.jpg
?   ?   ?   ??? gas-pump-2.jpg
?   ?   ?   ??? meter-1.jpg
?   ?   ?   ??? meter-2.jpg
?   ?   ?
?   ?   ??? pipeline/
?   ?   ?   ??? yellow-pipeline-1.jpg
?   ?   ?   ??? yellow-pipeline-2.jpg
?   ?   ?   ??? pipeline-installation.jpg
?   ?   ?   ??? pipeline-maintenance.jpg
?   ?   ?
?   ?   ??? hotels/
?   ?   ?   ??? 5-star-kitchen-1.jpg
?   ?   ?   ??? 5-star-kitchen-2.jpg
?   ?   ?   ??? 3-star-kitchen.jpg
?   ?   ?   ??? restaurant-supply.jpg
?   ?   ?   ??? commercial-kitchen.jpg
?   ?   ?
?   ?   ??? safety/
?   ?       ??? safety-inspection.jpg
?   ?       ??? testing-equipment.jpg
?   ?       ??? certification.jpg
?   ?
?   ??? pipeline/
?   ?   ??? main-yellow-pipeline.jpg
?   ?   ??? pipeline-process-1.jpg
?   ?   ??? pipeline-process-2.jpg
?   ?   ??? pipeline-process-3.jpg
?   ?
?   ??? infrastructure/
?   ?   ??? compressor-1.jpg
?   ?   ??? regulator-1.jpg
?   ?   ??? safety-valve.jpg
?   ?   ??? flow-meter.jpg
?   ?   ??? control-panel.jpg
?   ?   ??? testing-equipment.jpg
?   ?   ??? main-center.jpg
?   ?   ??? maintenance-center-1.jpg
?   ?   ??? maintenance-center-2.jpg
?   ?   ??? maintenance-center-3.jpg
?   ?
?   ??? locations/
?   ?   ??? main-center-office.jpg
?   ?   ??? north-zone.jpg
?   ?   ??? south-zone.jpg
?   ?   ??? east-zone.jpg
?   ?   ??? west-zone.jpg
?   ?   ??? suburban-area.jpg
?   ?
?   ??? logos/
?   ?   ??? company-logo.png
?   ?   ??? ongc-logo.png
?   ?   ??? favicon.ico
?   ?
?   ??? hero/
?       ??? hero-background.jpg
?       ??? hero-banner.jpg
?
??? css/
?   ??? site.css
?
??? js/
    ??? site.js
```

## File Naming Convention

Use descriptive, lowercase names with hyphens:

? **Good:**
```
gas-pump-equipment.jpg
yellow-pipeline-network.jpg
5-star-hotel-kitchen.jpg
north-zone-center.jpg
```

? **Avoid:**
```
image1.jpg
photo.jpg
pic.jpg
```

## Image Specifications

### Recommended Dimensions:

**Gallery Images:** 400×300 pixels (4:3 ratio)
**Full Display:** 800×600 pixels
**Hero Banner:** 1920×600 pixels
**Thumbnail:** 300×200 pixels

### File Formats:

- **JPG:** Photos and complex images
- **PNG:** Images with transparency
- **WebP:** Modern format for better compression
- **SVG:** Logos and icons

### File Size Guidelines:

- Gallery images: 50-150 KB
- Full images: 200-400 KB
- Hero banners: 300-500 KB
- Compressed with optimization tools

## Image Quality Settings

For best results, use these compression settings:

**JPG Quality:** 85% (good balance)
**PNG:** Optimize with tools like TinyPNG
**WebP:** 80% quality

## Using Local Images in Views

### Current (Unsplash URLs):
```html
<img src="https://images.unsplash.com/photo-xxxxx?w=400&h=300&fit=crop" alt="Description">
```

### Change to Local:
```html
<img src="/images/gallery/equipment/gas-pump-1.jpg" alt="ONGC Gas Pump Equipment">
```

## Steps to Replace Images

1. **Create folder structure** in `wwwroot/images/`
2. **Organize your images** by category
3. **Compress images** for web
4. **Update each .cshtml file** with new paths
5. **Test in browser** to verify display

## Image Optimization Tools

- **TinyPNG:** tinypng.com (JPG & PNG)
- **ImageMagick:** Command-line compression
- **Squoosh:** Google's web tool
- **FileOptimizer:** Batch processing

## Integration Commands

### Files to Update with Local Images:

1. **Views/Home/Index.cshtml** - Hero section
2. **Views/Home/Services.cshtml** - Feature images
3. **Views/Home/Gallery.cshtml** - 12+ gallery images
4. **Views/Home/Pipeline.cshtml** - 3+ pipeline images
5. **Views/Home/Infrastructure.cshtml** - 6+ equipment images
6. **Views/Home/Locations.cshtml** - 6+ location images

---

**Quick Start:**
1. Create `/wwwroot/images/` folder
2. Add subfolders as shown above
3. Upload your ONGC gas service images
4. Update URLs in .cshtml files
5. Test responsiveness on all devices

---

*Image Management Guide - Shree Krupa Engg Website*
