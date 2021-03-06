; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Vectra"
!define PRODUCT_VERSION "1.0"
!define PRODUCT_PUBLISHER "Vectra"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\Vectra.ar.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"

; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
;!define MUI_LICENSEPAGE_CHECKBOX
;!insertmacro MUI_PAGE_LICENSE "..\..\..\License.txt"
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\Vectra.ar.exe"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "..\..\..\VectraDeploy\VectraSetup.1.0.exe"
InstallDir "$PROGRAMFILES\Vectra\bin"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite ifnewer
  File "Vectra.DBA\bin\Release\Vectra.DBA.exe"
  File "Vectra.start\Vectra.start\bin\Release\Vectra.start.exe"
  File "Vectra.start\Vectra.gl\bin\Release\Vectra.gl.exe"
  File "Vectra.start\Vectra.ap\bin\Release\Vectra.ap.exe"
  File "Vectra.start\Vectra.ar\bin\Release\Vectra.ar.exe"
  File "Vectra\bin\Release\Vectra.ar.exe"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\sqlite3.def"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\sqlite3.dll"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\ZedGraph.dll"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\ZedGraph.xml"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\Devart.Data.dll"
  File "C:\Documents and Settings\Administrator\Desktop\Vectra.Deploy\Packages\Devart.Data.SQLite.dll"
  

  CreateDirectory "$SMPROGRAMS\Vectra"
  CreateShortCut "$SMPROGRAMS\Vectra\Vectra.lnk" "$INSTDIR\Vectra.start.exe"
  CreateShortCut "$SMPROGRAMS\Vectra\Vectra.AR.lnk" "$INSTDIR\Vectra.ar.exe"
  CreateShortCut "$SMPROGRAMS\Vectra\Vectra.DBA.lnk" "$INSTDIR\Vectra.DBA.exe"
 ; CreateShortCut "$DESKTOP\Vectra.lnk" "$INSTDIR\Vectra.start.exe"
 ; CreateShortCut "$DESKTOP\Vectra.AR.lnk" "$INSTDIR\Vectra.ar.exe"
SectionEnd

Section -AdditionalIcons
  CreateShortCut "$SMPROGRAMS\Vectra\Uninstall.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\Vectra.ar.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\Vectra.ar.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd


Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\Vectra.start.exe"
  Delete "$INSTDIR\Vectra.DBA.exe"
  Delete "$INSTDIR\Vectra.ar.exe"
  Delete "$INSTDIR\Vectra.ap.exe"
  Delete "$INSTDIR\Vectra.gl.exe"
  Delete "$INSTDIR\sqlite3.def"
  Delete "$INSTDIR\sqlite3.dll"
  Delete "$INSTDIR\ZedGraph.dll"
  Delete "$INSTDIR\ZedGraph.xml"
  Delete "$INSTDIR\vectra.log"
  Delete "$INSTDIR\Devart.Data.dll"
  Delete "$INSTDIR\Devart.Data.SQLite.dll"
  

  Delete "$SMPROGRAMS\Vectra\Uninstall.lnk"
  Delete "$DESKTOP\Vectra.lnk"
  Delete "$DESKTOP\Vectra.ar.lnk"
  Delete "$SMPROGRAMS\Vectra\Vectra.lnk"

  RMDir "$SMPROGRAMS\Vectra"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd