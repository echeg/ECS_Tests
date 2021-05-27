using System;
using Unity.Entities;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.UEcs{


class System0 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component377 c1,ref Component91 c2 ) =>{ }).Run(); }
}

class System1 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component398 c1 ) =>{ }).Run(); }
}

class System2 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component63 c1 ) =>{ }).Run(); }
}

class System3 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component405,Component292>()
.ForEach((ref Component488 c1,ref Component493 c2 ) =>{ }).Run(); }
}

class System4 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component405 c1 ) =>{ }).Run(); }
}

class System5 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component320>()
.ForEach((ref Component396 c1,ref Component71 c2 ) =>{ }).Run(); }
}

class System6 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component442>()
.ForEach((ref Component67 c1,ref Component47 c2 ) =>{ }).Run(); }
}

class System7 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component350,Component236>()
.ForEach((ref Component468 c1,ref Component249 c2 ) =>{ }).Run(); }
}

class System8 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component350 c1,ref Component306 c2 ) =>{ }).Run(); }
}

class System9 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component361>()
.ForEach((ref Component269 c1,ref Component10 c2 ) =>{ }).Run(); }
}

class System10 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component48>()
.ForEach((ref Component203 c1,ref Component195 c2 ) =>{ }).Run(); }
}

class System11 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component36 c1,ref Component337 c2 ) =>{ }).Run(); }
}

class System12 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component151>()
.ForEach((ref Component342 c1,ref Component386 c2 ) =>{ }).Run(); }
}

class System13 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component244>()
.ForEach((ref Component481 c1,ref Component115 c2 ) =>{ }).Run(); }
}

class System14 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component364>()
.ForEach((ref Component378 c1,ref Component24 c2 ) =>{ }).Run(); }
}

class System15 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component450>()
.ForEach((ref Component207 c1,ref Component280 c2 ) =>{ }).Run(); }
}

class System16 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component261 c1 ) =>{ }).Run(); }
}

class System17 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component323 c1 ) =>{ }).Run(); }
}

class System18 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component150,Component135>()
.ForEach((ref Component49 c1,ref Component181 c2 ) =>{ }).Run(); }
}

class System19 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component82>()
.ForEach((ref Component190 c1,ref Component141 c2 ) =>{ }).Run(); }
}

class System20 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component22 c1,ref Component151 c2 ) =>{ }).Run(); }
}

class System21 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component230 c1,ref Component271 c2 ) =>{ }).Run(); }
}

class System22 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component40 c1 ) =>{ }).Run(); }
}

class System23 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component120>()
.ForEach((ref Component498 c1,ref Component368 c2 ) =>{ }).Run(); }
}

class System24 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component318,Component405>()
.ForEach((ref Component16 c1,ref Component427 c2 ) =>{ }).Run(); }
}

class System25 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component153 c1,ref Component483 c2 ) =>{ }).Run(); }
}

class System26 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component121>()
.ForEach((ref Component72 c1,ref Component287 c2 ) =>{ }).Run(); }
}

class System27 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component418 c1,ref Component226 c2 ) =>{ }).Run(); }
}

class System28 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component236 c1,ref Component16 c2 ) =>{ }).Run(); }
}

class System29 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component161,Component134>()
.ForEach((ref Component291 c1,ref Component473 c2 ) =>{ }).Run(); }
}

class System30 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component45>()
.ForEach((ref Component372 c1,ref Component149 c2 ) =>{ }).Run(); }
}

class System31 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component306,Component262>()
.ForEach((ref Component180 c1,ref Component409 c2 ) =>{ }).Run(); }
}

class System32 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component203 c1,ref Component18 c2 ) =>{ }).Run(); }
}

class System33 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component253 c1 ) =>{ }).Run(); }
}

class System34 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component36>()
.ForEach((ref Component229 c1,ref Component47 c2 ) =>{ }).Run(); }
}

class System35 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component329 c1,ref Component127 c2 ) =>{ }).Run(); }
}

class System36 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component30 c1,ref Component2 c2 ) =>{ }).Run(); }
}

class System37 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component303>()
.ForEach((ref Component44 c1,ref Component439 c2 ) =>{ }).Run(); }
}

class System38 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component146>()
.ForEach((ref Component30 c1,ref Component77 c2 ) =>{ }).Run(); }
}

class System39 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component382 c1,ref Component72 c2 ) =>{ }).Run(); }
}

class System40 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component217,Component303>()
.ForEach((ref Component256 c1,ref Component189 c2 ) =>{ }).Run(); }
}

class System41 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component441>()
.ForEach((ref Component265 c1,ref Component24 c2 ) =>{ }).Run(); }
}

class System42 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component399 c1 ) =>{ }).Run(); }
}

class System43 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component406 c1,ref Component405 c2 ) =>{ }).Run(); }
}

class System44 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component315>()
.ForEach((ref Component420 c1,ref Component255 c2 ) =>{ }).Run(); }
}

class System45 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component342>()
.ForEach((ref Component6 c1,ref Component120 c2 ) =>{ }).Run(); }
}

class System46 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component233 c1,ref Component391 c2 ) =>{ }).Run(); }
}

class System47 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component106 c1,ref Component6 c2 ) =>{ }).Run(); }
}

class System48 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component101 c1,ref Component56 c2 ) =>{ }).Run(); }
}

class System49 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component385>()
.ForEach((ref Component150 c1,ref Component181 c2 ) =>{ }).Run(); }
}

class System50 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component354,Component486>()
.ForEach((ref Component357 c1,ref Component319 c2 ) =>{ }).Run(); }
}

class System51 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component492>()
.ForEach((ref Component210 c1,ref Component88 c2 ) =>{ }).Run(); }
}

class System52 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component398,Component13>()
.ForEach((ref Component351 c1,ref Component32 c2 ) =>{ }).Run(); }
}

class System53 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component322 c1 ) =>{ }).Run(); }
}

class System54 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component452>()
.ForEach((ref Component405 c1,ref Component376 c2 ) =>{ }).Run(); }
}

class System55 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component109 c1 ) =>{ }).Run(); }
}

class System56 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component237,Component258>()
.ForEach((ref Component326 c1,ref Component62 c2 ) =>{ }).Run(); }
}

class System57 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component118>()
.ForEach((ref Component339 c1,ref Component453 c2 ) =>{ }).Run(); }
}

class System58 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component225 c1 ) =>{ }).Run(); }
}

class System59 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component313 c1 ) =>{ }).Run(); }
}

class System60 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component435 c1 ) =>{ }).Run(); }
}

class System61 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component409,Component253>()
.ForEach((ref Component346 c1,ref Component144 c2 ) =>{ }).Run(); }
}

class System62 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component322 c1,ref Component39 c2 ) =>{ }).Run(); }
}

class System63 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component207 c1,ref Component493 c2 ) =>{ }).Run(); }
}

class System64 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component279 c1 ) =>{ }).Run(); }
}

class System65 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component375 c1,ref Component274 c2 ) =>{ }).Run(); }
}

class System66 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component281 c1,ref Component363 c2 ) =>{ }).Run(); }
}

class System67 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component248,Component103>()
.ForEach((ref Component492 c1,ref Component292 c2 ) =>{ }).Run(); }
}

class System68 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component292,Component307>()
.ForEach((ref Component248 c1,ref Component38 c2 ) =>{ }).Run(); }
}

class System69 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component47>()
.ForEach((ref Component378 c1,ref Component199 c2 ) =>{ }).Run(); }
}

class System70 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component232,Component42>()
.ForEach((ref Component370 c1,ref Component59 c2 ) =>{ }).Run(); }
}

class System71 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component286>()
.ForEach((ref Component454 c1,ref Component133 c2 ) =>{ }).Run(); }
}

class System72 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component170>()
.ForEach((ref Component30 c1,ref Component265 c2 ) =>{ }).Run(); }
}

class System73 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component228 c1 ) =>{ }).Run(); }
}

class System74 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component269 c1,ref Component495 c2 ) =>{ }).Run(); }
}

class System75 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component450 c1,ref Component160 c2 ) =>{ }).Run(); }
}

class System76 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component40,Component490>()
.ForEach((ref Component168 c1,ref Component97 c2 ) =>{ }).Run(); }
}

class System77 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component116 c1 ) =>{ }).Run(); }
}

class System78 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component232 c1 ) =>{ }).Run(); }
}

class System79 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component74,Component393>()
.ForEach((ref Component328 c1,ref Component293 c2 ) =>{ }).Run(); }
}

class System80 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component186>()
.ForEach((ref Component315 c1,ref Component42 c2 ) =>{ }).Run(); }
}

class System81 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component206,Component439>()
.ForEach((ref Component408 c1,ref Component268 c2 ) =>{ }).Run(); }
}

class System82 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component337 c1,ref Component248 c2 ) =>{ }).Run(); }
}

class System83 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component309 c1,ref Component48 c2 ) =>{ }).Run(); }
}

class System84 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component311 c1 ) =>{ }).Run(); }
}

class System85 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component249 c1,ref Component387 c2 ) =>{ }).Run(); }
}

class System86 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component191,Component51>()
.ForEach((ref Component202 c1,ref Component461 c2 ) =>{ }).Run(); }
}

class System87 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component54>()
.ForEach((ref Component338 c1,ref Component104 c2 ) =>{ }).Run(); }
}

class System88 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component95,Component166>()
.ForEach((ref Component201 c1,ref Component472 c2 ) =>{ }).Run(); }
}

class System89 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component308>()
.ForEach((ref Component428 c1,ref Component227 c2 ) =>{ }).Run(); }
}

class System90 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component236>()
.ForEach((ref Component42 c1,ref Component392 c2 ) =>{ }).Run(); }
}

class System91 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component379 c1,ref Component203 c2 ) =>{ }).Run(); }
}

class System92 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component315 c1,ref Component307 c2 ) =>{ }).Run(); }
}

class System93 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component188,Component44>()
.ForEach((ref Component193 c1,ref Component91 c2 ) =>{ }).Run(); }
}

class System94 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component450 c1,ref Component152 c2 ) =>{ }).Run(); }
}

class System95 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component83>()
.ForEach((ref Component350 c1,ref Component135 c2 ) =>{ }).Run(); }
}

class System96 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component163 c1 ) =>{ }).Run(); }
}

class System97 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component488 c1,ref Component17 c2 ) =>{ }).Run(); }
}

class System98 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component435>()
.ForEach((ref Component153 c1,ref Component21 c2 ) =>{ }).Run(); }
}

class System99 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component311 c1 ) =>{ }).Run(); }
}

class System100 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component332 c1 ) =>{ }).Run(); }
}

class System101 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component494 c1,ref Component206 c2 ) =>{ }).Run(); }
}

class System102 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component309,Component31>()
.ForEach((ref Component82 c1,ref Component487 c2 ) =>{ }).Run(); }
}

class System103 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component124 c1 ) =>{ }).Run(); }
}

class System104 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component427>()
.ForEach((ref Component359 c1,ref Component13 c2 ) =>{ }).Run(); }
}

class System105 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component73,Component376>()
.ForEach((ref Component216 c1,ref Component222 c2 ) =>{ }).Run(); }
}

class System106 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component224 c1,ref Component472 c2 ) =>{ }).Run(); }
}

class System107 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component84 c1,ref Component240 c2 ) =>{ }).Run(); }
}

class System108 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component293>()
.ForEach((ref Component337 c1,ref Component89 c2 ) =>{ }).Run(); }
}

class System109 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component88>()
.ForEach((ref Component359 c1,ref Component381 c2 ) =>{ }).Run(); }
}

class System110 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component243>()
.ForEach((ref Component337 c1,ref Component193 c2 ) =>{ }).Run(); }
}

class System111 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component271 c1,ref Component362 c2 ) =>{ }).Run(); }
}

class System112 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component38>()
.ForEach((ref Component52 c1,ref Component39 c2 ) =>{ }).Run(); }
}

class System113 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component437>()
.ForEach((ref Component128 c1,ref Component3 c2 ) =>{ }).Run(); }
}

class System114 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component305 c1,ref Component212 c2 ) =>{ }).Run(); }
}

class System115 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component435 c1 ) =>{ }).Run(); }
}

class System116 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component265>()
.ForEach((ref Component107 c1,ref Component234 c2 ) =>{ }).Run(); }
}

class System117 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component233 c1 ) =>{ }).Run(); }
}

class System118 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component150 c1,ref Component220 c2 ) =>{ }).Run(); }
}

class System119 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component158 c1,ref Component265 c2 ) =>{ }).Run(); }
}

class System120 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component90,Component214>()
.ForEach((ref Component270 c1,ref Component156 c2 ) =>{ }).Run(); }
}

class System121 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component13,Component348>()
.ForEach((ref Component43 c1,ref Component302 c2 ) =>{ }).Run(); }
}

class System122 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component432 c1,ref Component190 c2 ) =>{ }).Run(); }
}

class System123 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component399>()
.ForEach((ref Component111 c1,ref Component358 c2 ) =>{ }).Run(); }
}

class System124 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component312>()
.ForEach((ref Component488 c1,ref Component159 c2 ) =>{ }).Run(); }
}

class System125 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component102,Component427>()
.ForEach((ref Component260 c1,ref Component248 c2 ) =>{ }).Run(); }
}

class System126 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component445 c1 ) =>{ }).Run(); }
}

class System127 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component212 c1 ) =>{ }).Run(); }
}

class System128 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component315 c1 ) =>{ }).Run(); }
}

class System129 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component357,Component346>()
.ForEach((ref Component273 c1,ref Component312 c2 ) =>{ }).Run(); }
}

class System130 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component169>()
.ForEach((ref Component31 c1,ref Component331 c2 ) =>{ }).Run(); }
}

class System131 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component421 c1,ref Component480 c2 ) =>{ }).Run(); }
}

class System132 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component329,Component121>()
.ForEach((ref Component301 c1,ref Component75 c2 ) =>{ }).Run(); }
}

class System133 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component249>()
.ForEach((ref Component250 c1,ref Component376 c2 ) =>{ }).Run(); }
}

class System134 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component10,Component408>()
.ForEach((ref Component453 c1,ref Component31 c2 ) =>{ }).Run(); }
}

class System135 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component97,Component250>()
.ForEach((ref Component287 c1,ref Component352 c2 ) =>{ }).Run(); }
}

class System136 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component51>()
.ForEach((ref Component242 c1,ref Component356 c2 ) =>{ }).Run(); }
}

class System137 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component11,Component52>()
.ForEach((ref Component479 c1,ref Component254 c2 ) =>{ }).Run(); }
}

class System138 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component67>()
.ForEach((ref Component156 c1,ref Component490 c2 ) =>{ }).Run(); }
}

class System139 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component280 c1 ) =>{ }).Run(); }
}

class System140 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component291>()
.ForEach((ref Component301 c1,ref Component351 c2 ) =>{ }).Run(); }
}

class System141 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component229>()
.ForEach((ref Component189 c1,ref Component462 c2 ) =>{ }).Run(); }
}

class System142 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component382 c1 ) =>{ }).Run(); }
}

class System143 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component438>()
.ForEach((ref Component280 c1,ref Component347 c2 ) =>{ }).Run(); }
}

class System144 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component71>()
.ForEach((ref Component244 c1,ref Component479 c2 ) =>{ }).Run(); }
}

class System145 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component79,Component250>()
.ForEach((ref Component121 c1,ref Component237 c2 ) =>{ }).Run(); }
}

class System146 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component349 c1,ref Component366 c2 ) =>{ }).Run(); }
}

class System147 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component92>()
.ForEach((ref Component198 c1,ref Component64 c2 ) =>{ }).Run(); }
}

class System148 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component385 c1 ) =>{ }).Run(); }
}

class System149 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component230 c1 ) =>{ }).Run(); }
}

class System150 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component186 c1 ) =>{ }).Run(); }
}

class System151 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component337>()
.ForEach((ref Component61 c1,ref Component273 c2 ) =>{ }).Run(); }
}

class System152 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component290 c1 ) =>{ }).Run(); }
}

class System153 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component95 c1,ref Component199 c2 ) =>{ }).Run(); }
}

class System154 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component68,Component176>()
.ForEach((ref Component73 c1,ref Component191 c2 ) =>{ }).Run(); }
}

class System155 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component42,Component233>()
.ForEach((ref Component72 c1,ref Component404 c2 ) =>{ }).Run(); }
}

class System156 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component192 c1 ) =>{ }).Run(); }
}

class System157 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component264,Component165>()
.ForEach((ref Component458 c1,ref Component338 c2 ) =>{ }).Run(); }
}

class System158 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component274,Component117>()
.ForEach((ref Component374 c1,ref Component434 c2 ) =>{ }).Run(); }
}

class System159 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component418>()
.ForEach((ref Component174 c1,ref Component308 c2 ) =>{ }).Run(); }
}

class System160 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component224>()
.ForEach((ref Component432 c1,ref Component283 c2 ) =>{ }).Run(); }
}

class System161 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component150>()
.ForEach((ref Component81 c1,ref Component63 c2 ) =>{ }).Run(); }
}

class System162 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component495,Component415>()
.ForEach((ref Component277 c1,ref Component6 c2 ) =>{ }).Run(); }
}

class System163 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component312 c1 ) =>{ }).Run(); }
}

class System164 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component187 c1 ) =>{ }).Run(); }
}

class System165 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component119>()
.ForEach((ref Component135 c1,ref Component243 c2 ) =>{ }).Run(); }
}

class System166 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component348>()
.ForEach((ref Component222 c1,ref Component73 c2 ) =>{ }).Run(); }
}

class System167 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component425>()
.ForEach((ref Component294 c1,ref Component160 c2 ) =>{ }).Run(); }
}

class System168 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component259>()
.ForEach((ref Component230 c1,ref Component16 c2 ) =>{ }).Run(); }
}

class System169 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component120>()
.ForEach((ref Component119 c1,ref Component140 c2 ) =>{ }).Run(); }
}

class System170 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component128>()
.ForEach((ref Component444 c1,ref Component468 c2 ) =>{ }).Run(); }
}

class System171 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component257>()
.ForEach((ref Component498 c1,ref Component61 c2 ) =>{ }).Run(); }
}

class System172 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component57 c1,ref Component283 c2 ) =>{ }).Run(); }
}

class System173 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component171 c1 ) =>{ }).Run(); }
}

class System174 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component65,Component298>()
.ForEach((ref Component480 c1,ref Component39 c2 ) =>{ }).Run(); }
}

class System175 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component471>()
.ForEach((ref Component209 c1,ref Component376 c2 ) =>{ }).Run(); }
}

class System176 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component168>()
.ForEach((ref Component403 c1,ref Component225 c2 ) =>{ }).Run(); }
}

class System177 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component490 c1 ) =>{ }).Run(); }
}

class System178 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component157 c1,ref Component470 c2 ) =>{ }).Run(); }
}

class System179 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component481 c1,ref Component368 c2 ) =>{ }).Run(); }
}

class System180 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component329,Component316>()
.ForEach((ref Component167 c1,ref Component114 c2 ) =>{ }).Run(); }
}

class System181 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component315 c1,ref Component178 c2 ) =>{ }).Run(); }
}

class System182 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component253>()
.ForEach((ref Component11 c1,ref Component38 c2 ) =>{ }).Run(); }
}

class System183 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component193>()
.ForEach((ref Component250 c1,ref Component477 c2 ) =>{ }).Run(); }
}

class System184 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component411,Component442>()
.ForEach((ref Component135 c1,ref Component430 c2 ) =>{ }).Run(); }
}

class System185 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component64,Component330>()
.ForEach((ref Component181 c1,ref Component225 c2 ) =>{ }).Run(); }
}

class System186 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component267 c1 ) =>{ }).Run(); }
}

class System187 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component448,Component189>()
.ForEach((ref Component399 c1,ref Component312 c2 ) =>{ }).Run(); }
}

class System188 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component62 c1 ) =>{ }).Run(); }
}

class System189 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component167>()
.ForEach((ref Component450 c1,ref Component469 c2 ) =>{ }).Run(); }
}

class System190 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component393 c1 ) =>{ }).Run(); }
}

class System191 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component211 c1,ref Component276 c2 ) =>{ }).Run(); }
}

class System192 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component297>()
.ForEach((ref Component472 c1,ref Component308 c2 ) =>{ }).Run(); }
}

class System193 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component42 c1 ) =>{ }).Run(); }
}

class System194 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component335 c1,ref Component242 c2 ) =>{ }).Run(); }
}

class System195 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component426 c1 ) =>{ }).Run(); }
}

class System196 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component264>()
.ForEach((ref Component485 c1,ref Component389 c2 ) =>{ }).Run(); }
}

class System197 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component48 c1,ref Component245 c2 ) =>{ }).Run(); }
}

class System198 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component63>()
.ForEach((ref Component198 c1,ref Component89 c2 ) =>{ }).Run(); }
}

class System199 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component243>()
.ForEach((ref Component187 c1,ref Component105 c2 ) =>{ }).Run(); }
}

class System200 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component17,Component244>()
.ForEach((ref Component467 c1,ref Component382 c2 ) =>{ }).Run(); }
}

class System201 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component92>()
.ForEach((ref Component404 c1,ref Component361 c2 ) =>{ }).Run(); }
}

class System202 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component216 c1 ) =>{ }).Run(); }
}

class System203 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component477>()
.ForEach((ref Component390 c1,ref Component201 c2 ) =>{ }).Run(); }
}

class System204 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component119 c1,ref Component134 c2 ) =>{ }).Run(); }
}

class System205 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component385 c1 ) =>{ }).Run(); }
}

class System206 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component205 c1 ) =>{ }).Run(); }
}

class System207 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component399 c1,ref Component345 c2 ) =>{ }).Run(); }
}

class System208 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component274,Component408>()
.ForEach((ref Component351 c1,ref Component77 c2 ) =>{ }).Run(); }
}

class System209 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component109 c1 ) =>{ }).Run(); }
}

class System210 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component367,Component360>()
.ForEach((ref Component299 c1,ref Component208 c2 ) =>{ }).Run(); }
}

class System211 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component181 c1 ) =>{ }).Run(); }
}

class System212 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component81 c1,ref Component28 c2 ) =>{ }).Run(); }
}

class System213 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component463 c1,ref Component431 c2 ) =>{ }).Run(); }
}

class System214 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component221>()
.ForEach((ref Component355 c1,ref Component159 c2 ) =>{ }).Run(); }
}

class System215 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component71,Component219>()
.ForEach((ref Component444 c1,ref Component164 c2 ) =>{ }).Run(); }
}

class System216 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component284 c1,ref Component285 c2 ) =>{ }).Run(); }
}

class System217 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component408,Component327>()
.ForEach((ref Component171 c1,ref Component293 c2 ) =>{ }).Run(); }
}

class System218 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component184 c1 ) =>{ }).Run(); }
}

class System219 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component107 c1 ) =>{ }).Run(); }
}

class System220 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component109>()
.ForEach((ref Component91 c1,ref Component492 c2 ) =>{ }).Run(); }
}

class System221 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component431>()
.ForEach((ref Component65 c1,ref Component453 c2 ) =>{ }).Run(); }
}

class System222 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component218>()
.ForEach((ref Component32 c1,ref Component33 c2 ) =>{ }).Run(); }
}

class System223 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component192,Component356>()
.ForEach((ref Component50 c1,ref Component96 c2 ) =>{ }).Run(); }
}

class System224 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component37,Component187>()
.ForEach((ref Component463 c1,ref Component343 c2 ) =>{ }).Run(); }
}

class System225 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component423 c1 ) =>{ }).Run(); }
}

class System226 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component377 c1 ) =>{ }).Run(); }
}

class System227 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component253,Component441>()
.ForEach((ref Component388 c1,ref Component276 c2 ) =>{ }).Run(); }
}

class System228 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component447,Component264>()
.ForEach((ref Component449 c1,ref Component323 c2 ) =>{ }).Run(); }
}

class System229 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component111 c1,ref Component37 c2 ) =>{ }).Run(); }
}

class System230 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component414,Component150>()
.ForEach((ref Component211 c1,ref Component139 c2 ) =>{ }).Run(); }
}

class System231 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component121>()
.ForEach((ref Component67 c1,ref Component13 c2 ) =>{ }).Run(); }
}

class System232 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component216 c1,ref Component470 c2 ) =>{ }).Run(); }
}

class System233 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component220 c1,ref Component170 c2 ) =>{ }).Run(); }
}

class System234 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component159 c1 ) =>{ }).Run(); }
}

class System235 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component467,Component184>()
.ForEach((ref Component68 c1,ref Component28 c2 ) =>{ }).Run(); }
}

class System236 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component155 c1 ) =>{ }).Run(); }
}

class System237 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component90 c1 ) =>{ }).Run(); }
}

class System238 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component268 c1 ) =>{ }).Run(); }
}

class System239 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component102 c1,ref Component331 c2 ) =>{ }).Run(); }
}

class System240 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component245 c1 ) =>{ }).Run(); }
}

class System241 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component398>()
.ForEach((ref Component85 c1,ref Component131 c2 ) =>{ }).Run(); }
}

class System242 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component13>()
.ForEach((ref Component465 c1,ref Component172 c2 ) =>{ }).Run(); }
}

class System243 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component59>()
.ForEach((ref Component260 c1,ref Component191 c2 ) =>{ }).Run(); }
}

class System244 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component279>()
.ForEach((ref Component245 c1,ref Component266 c2 ) =>{ }).Run(); }
}

class System245 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component98>()
.ForEach((ref Component288 c1,ref Component289 c2 ) =>{ }).Run(); }
}

class System246 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component69 c1 ) =>{ }).Run(); }
}

class System247 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component146 c1,ref Component484 c2 ) =>{ }).Run(); }
}

class System248 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component299>()
.ForEach((ref Component60 c1,ref Component203 c2 ) =>{ }).Run(); }
}

class System249 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component190>()
.ForEach((ref Component19 c1,ref Component365 c2 ) =>{ }).Run(); }
}

class System250 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component343 c1,ref Component135 c2 ) =>{ }).Run(); }
}

class System251 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component171 c1 ) =>{ }).Run(); }
}

class System252 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component14,Component103>()
.ForEach((ref Component9 c1,ref Component395 c2 ) =>{ }).Run(); }
}

class System253 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component267,Component345>()
.ForEach((ref Component373 c1,ref Component95 c2 ) =>{ }).Run(); }
}

class System254 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component313>()
.ForEach((ref Component488 c1,ref Component390 c2 ) =>{ }).Run(); }
}

class System255 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component427 c1 ) =>{ }).Run(); }
}

class System256 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component282 c1,ref Component391 c2 ) =>{ }).Run(); }
}

class System257 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component405,Component468>()
.ForEach((ref Component414 c1,ref Component408 c2 ) =>{ }).Run(); }
}

class System258 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component494 c1,ref Component241 c2 ) =>{ }).Run(); }
}

class System259 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component401>()
.ForEach((ref Component368 c1,ref Component58 c2 ) =>{ }).Run(); }
}

class System260 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component241 c1,ref Component83 c2 ) =>{ }).Run(); }
}

class System261 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component68,Component465>()
.ForEach((ref Component280 c1,ref Component202 c2 ) =>{ }).Run(); }
}

class System262 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component96>()
.ForEach((ref Component273 c1,ref Component388 c2 ) =>{ }).Run(); }
}

class System263 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component423 c1,ref Component311 c2 ) =>{ }).Run(); }
}

class System264 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component263,Component61>()
.ForEach((ref Component205 c1,ref Component322 c2 ) =>{ }).Run(); }
}

class System265 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component244 c1 ) =>{ }).Run(); }
}

class System266 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component256 c1 ) =>{ }).Run(); }
}

class System267 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component300,Component108>()
.ForEach((ref Component103 c1,ref Component426 c2 ) =>{ }).Run(); }
}

class System268 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component48 c1,ref Component226 c2 ) =>{ }).Run(); }
}

class System269 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component443 c1,ref Component149 c2 ) =>{ }).Run(); }
}

class System270 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component307 c1,ref Component411 c2 ) =>{ }).Run(); }
}

class System271 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component316>()
.ForEach((ref Component224 c1,ref Component94 c2 ) =>{ }).Run(); }
}

class System272 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component211 c1 ) =>{ }).Run(); }
}

class System273 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component311 c1 ) =>{ }).Run(); }
}

class System274 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component45 c1,ref Component403 c2 ) =>{ }).Run(); }
}

class System275 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component35 c1 ) =>{ }).Run(); }
}

class System276 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component105 c1 ) =>{ }).Run(); }
}

class System277 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component188,Component326>()
.ForEach((ref Component340 c1,ref Component386 c2 ) =>{ }).Run(); }
}

class System278 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component267,Component356>()
.ForEach((ref Component176 c1,ref Component276 c2 ) =>{ }).Run(); }
}

class System279 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component224 c1 ) =>{ }).Run(); }
}

class System280 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component387 c1,ref Component271 c2 ) =>{ }).Run(); }
}

class System281 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component293>()
.ForEach((ref Component64 c1,ref Component171 c2 ) =>{ }).Run(); }
}

class System282 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component39 c1 ) =>{ }).Run(); }
}

class System283 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component341,Component231>()
.ForEach((ref Component244 c1,ref Component123 c2 ) =>{ }).Run(); }
}

class System284 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component412 c1,ref Component380 c2 ) =>{ }).Run(); }
}

class System285 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component45,Component121>()
.ForEach((ref Component92 c1,ref Component147 c2 ) =>{ }).Run(); }
}

class System286 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component102 c1,ref Component263 c2 ) =>{ }).Run(); }
}

class System287 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component481 c1 ) =>{ }).Run(); }
}

class System288 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component327,Component460>()
.ForEach((ref Component85 c1,ref Component448 c2 ) =>{ }).Run(); }
}

class System289 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component487 c1 ) =>{ }).Run(); }
}

class System290 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component272>()
.ForEach((ref Component424 c1,ref Component419 c2 ) =>{ }).Run(); }
}

class System291 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component442>()
.ForEach((ref Component345 c1,ref Component242 c2 ) =>{ }).Run(); }
}

class System292 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component30 c1 ) =>{ }).Run(); }
}

class System293 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component263 c1 ) =>{ }).Run(); }
}

class System294 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component264>()
.ForEach((ref Component94 c1,ref Component257 c2 ) =>{ }).Run(); }
}

class System295 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component439,Component179>()
.ForEach((ref Component370 c1,ref Component264 c2 ) =>{ }).Run(); }
}

class System296 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component176 c1 ) =>{ }).Run(); }
}

class System297 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component9 c1,ref Component6 c2 ) =>{ }).Run(); }
}

class System298 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component305 c1,ref Component474 c2 ) =>{ }).Run(); }
}

class System299 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component139 c1 ) =>{ }).Run(); }
}

class System300 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component367>()
.ForEach((ref Component89 c1,ref Component354 c2 ) =>{ }).Run(); }
}

class System301 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component493 c1,ref Component107 c2 ) =>{ }).Run(); }
}

class System302 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component247 c1 ) =>{ }).Run(); }
}

class System303 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component181,Component6>()
.ForEach((ref Component103 c1,ref Component55 c2 ) =>{ }).Run(); }
}

class System304 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component211 c1 ) =>{ }).Run(); }
}

class System305 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component52,Component457>()
.ForEach((ref Component230 c1,ref Component321 c2 ) =>{ }).Run(); }
}

class System306 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component94 c1,ref Component307 c2 ) =>{ }).Run(); }
}

class System307 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component263>()
.ForEach((ref Component248 c1,ref Component251 c2 ) =>{ }).Run(); }
}

class System308 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component467>()
.ForEach((ref Component154 c1,ref Component436 c2 ) =>{ }).Run(); }
}

class System309 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component173,Component492>()
.ForEach((ref Component390 c1,ref Component312 c2 ) =>{ }).Run(); }
}

class System310 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component15 c1,ref Component271 c2 ) =>{ }).Run(); }
}

class System311 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component34>()
.ForEach((ref Component311 c1,ref Component16 c2 ) =>{ }).Run(); }
}

class System312 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component485 c1 ) =>{ }).Run(); }
}

class System313 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component295,Component304>()
.ForEach((ref Component162 c1,ref Component9 c2 ) =>{ }).Run(); }
}

class System314 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component153 c1 ) =>{ }).Run(); }
}

class System315 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component182 c1 ) =>{ }).Run(); }
}

class System316 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component494 c1 ) =>{ }).Run(); }
}

class System317 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component43 c1 ) =>{ }).Run(); }
}

class System318 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component226,Component92>()
.ForEach((ref Component241 c1,ref Component344 c2 ) =>{ }).Run(); }
}

class System319 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component291,Component193>()
.ForEach((ref Component135 c1,ref Component80 c2 ) =>{ }).Run(); }
}

class System320 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component214>()
.ForEach((ref Component218 c1,ref Component158 c2 ) =>{ }).Run(); }
}

class System321 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component264 c1 ) =>{ }).Run(); }
}

class System322 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component178 c1,ref Component60 c2 ) =>{ }).Run(); }
}

class System323 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component338 c1,ref Component253 c2 ) =>{ }).Run(); }
}

class System324 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component253 c1 ) =>{ }).Run(); }
}

class System325 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component350 c1 ) =>{ }).Run(); }
}

class System326 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component207>()
.ForEach((ref Component314 c1,ref Component436 c2 ) =>{ }).Run(); }
}

class System327 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component179 c1,ref Component446 c2 ) =>{ }).Run(); }
}

class System328 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component21 c1,ref Component29 c2 ) =>{ }).Run(); }
}

class System329 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component65,Component441>()
.ForEach((ref Component85 c1,ref Component424 c2 ) =>{ }).Run(); }
}

class System330 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component183,Component76>()
.ForEach((ref Component202 c1,ref Component468 c2 ) =>{ }).Run(); }
}

class System331 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component360 c1,ref Component103 c2 ) =>{ }).Run(); }
}

class System332 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component434>()
.ForEach((ref Component37 c1,ref Component409 c2 ) =>{ }).Run(); }
}

class System333 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component153>()
.ForEach((ref Component205 c1,ref Component239 c2 ) =>{ }).Run(); }
}

class System334 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component188 c1 ) =>{ }).Run(); }
}

class System335 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component108 c1,ref Component320 c2 ) =>{ }).Run(); }
}

class System336 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component83 c1,ref Component469 c2 ) =>{ }).Run(); }
}

class System337 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component271 c1,ref Component474 c2 ) =>{ }).Run(); }
}

class System338 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component20 c1,ref Component321 c2 ) =>{ }).Run(); }
}

class System339 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component254 c1 ) =>{ }).Run(); }
}

class System340 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component50,Component120>()
.ForEach((ref Component290 c1,ref Component433 c2 ) =>{ }).Run(); }
}

class System341 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component460 c1 ) =>{ }).Run(); }
}

class System342 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component499 c1,ref Component211 c2 ) =>{ }).Run(); }
}

class System343 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component170 c1,ref Component314 c2 ) =>{ }).Run(); }
}

class System344 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component131 c1,ref Component477 c2 ) =>{ }).Run(); }
}

class System345 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component396>()
.ForEach((ref Component376 c1,ref Component351 c2 ) =>{ }).Run(); }
}

class System346 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component456 c1,ref Component120 c2 ) =>{ }).Run(); }
}

class System347 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component36>()
.ForEach((ref Component119 c1,ref Component498 c2 ) =>{ }).Run(); }
}

class System348 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component82>()
.ForEach((ref Component170 c1,ref Component168 c2 ) =>{ }).Run(); }
}

class System349 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component438,Component24>()
.ForEach((ref Component476 c1,ref Component155 c2 ) =>{ }).Run(); }
}

class System350 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component21>()
.ForEach((ref Component189 c1,ref Component32 c2 ) =>{ }).Run(); }
}

class System351 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component36 c1,ref Component108 c2 ) =>{ }).Run(); }
}

class System352 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component482 c1 ) =>{ }).Run(); }
}

class System353 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component140,Component496>()
.ForEach((ref Component154 c1,ref Component401 c2 ) =>{ }).Run(); }
}

class System354 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component163,Component71>()
.ForEach((ref Component144 c1,ref Component470 c2 ) =>{ }).Run(); }
}

class System355 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component170 c1 ) =>{ }).Run(); }
}

class System356 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component431 c1,ref Component121 c2 ) =>{ }).Run(); }
}

class System357 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component155 c1 ) =>{ }).Run(); }
}

class System358 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component331 c1 ) =>{ }).Run(); }
}

class System359 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component210 c1,ref Component193 c2 ) =>{ }).Run(); }
}

class System360 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component306 c1,ref Component106 c2 ) =>{ }).Run(); }
}

class System361 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component92 c1,ref Component343 c2 ) =>{ }).Run(); }
}

class System362 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component348>()
.ForEach((ref Component167 c1,ref Component146 c2 ) =>{ }).Run(); }
}

class System363 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component278 c1 ) =>{ }).Run(); }
}

class System364 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component344 c1,ref Component134 c2 ) =>{ }).Run(); }
}

class System365 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component173 c1,ref Component256 c2 ) =>{ }).Run(); }
}

class System366 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component83,Component399>()
.ForEach((ref Component481 c1,ref Component313 c2 ) =>{ }).Run(); }
}

class System367 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component410>()
.ForEach((ref Component99 c1,ref Component257 c2 ) =>{ }).Run(); }
}

class System368 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component276,Component481>()
.ForEach((ref Component73 c1,ref Component1 c2 ) =>{ }).Run(); }
}

class System369 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component95>()
.ForEach((ref Component218 c1,ref Component494 c2 ) =>{ }).Run(); }
}

class System370 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component291 c1 ) =>{ }).Run(); }
}

class System371 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component496>()
.ForEach((ref Component300 c1,ref Component140 c2 ) =>{ }).Run(); }
}

class System372 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component394,Component224>()
.ForEach((ref Component190 c1,ref Component159 c2 ) =>{ }).Run(); }
}

class System373 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component361>()
.ForEach((ref Component398 c1,ref Component490 c2 ) =>{ }).Run(); }
}

class System374 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component190 c1 ) =>{ }).Run(); }
}

class System375 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component380 c1,ref Component76 c2 ) =>{ }).Run(); }
}

class System376 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component335,Component433>()
.ForEach((ref Component251 c1,ref Component106 c2 ) =>{ }).Run(); }
}

class System377 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component71>()
.ForEach((ref Component93 c1,ref Component145 c2 ) =>{ }).Run(); }
}

class System378 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component6 c1 ) =>{ }).Run(); }
}

class System379 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component130,Component382>()
.ForEach((ref Component349 c1,ref Component38 c2 ) =>{ }).Run(); }
}

class System380 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component316,Component159>()
.ForEach((ref Component137 c1,ref Component340 c2 ) =>{ }).Run(); }
}

class System381 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component195 c1,ref Component204 c2 ) =>{ }).Run(); }
}

class System382 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component133 c1 ) =>{ }).Run(); }
}

class System383 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component83 c1 ) =>{ }).Run(); }
}

class System384 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component202 c1,ref Component290 c2 ) =>{ }).Run(); }
}

class System385 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component337 c1 ) =>{ }).Run(); }
}

class System386 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component185,Component483>()
.ForEach((ref Component189 c1,ref Component282 c2 ) =>{ }).Run(); }
}

class System387 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component278>()
.ForEach((ref Component299 c1,ref Component402 c2 ) =>{ }).Run(); }
}

class System388 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component130 c1 ) =>{ }).Run(); }
}

class System389 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component359,Component360>()
.ForEach((ref Component236 c1,ref Component427 c2 ) =>{ }).Run(); }
}

class System390 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component388,Component64>()
.ForEach((ref Component136 c1,ref Component53 c2 ) =>{ }).Run(); }
}

class System391 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component401,Component301>()
.ForEach((ref Component196 c1,ref Component56 c2 ) =>{ }).Run(); }
}

class System392 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component6>()
.ForEach((ref Component252 c1,ref Component10 c2 ) =>{ }).Run(); }
}

class System393 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component150>()
.ForEach((ref Component238 c1,ref Component462 c2 ) =>{ }).Run(); }
}

class System394 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component197,Component455>()
.ForEach((ref Component349 c1,ref Component347 c2 ) =>{ }).Run(); }
}

class System395 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component380>()
.ForEach((ref Component40 c1,ref Component414 c2 ) =>{ }).Run(); }
}

class System396 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component64 c1 ) =>{ }).Run(); }
}

class System397 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component229>()
.ForEach((ref Component296 c1,ref Component205 c2 ) =>{ }).Run(); }
}

class System398 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component160 c1,ref Component65 c2 ) =>{ }).Run(); }
}

class System399 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component155 c1,ref Component273 c2 ) =>{ }).Run(); }
}

class System400 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component492 c1 ) =>{ }).Run(); }
}

class System401 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component283 c1,ref Component181 c2 ) =>{ }).Run(); }
}

class System402 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component47 c1 ) =>{ }).Run(); }
}

class System403 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component391,Component425>()
.ForEach((ref Component272 c1,ref Component249 c2 ) =>{ }).Run(); }
}

class System404 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component497 c1 ) =>{ }).Run(); }
}

class System405 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component12 c1 ) =>{ }).Run(); }
}

class System406 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component347>()
.ForEach((ref Component181 c1,ref Component283 c2 ) =>{ }).Run(); }
}

class System407 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component36 c1,ref Component106 c2 ) =>{ }).Run(); }
}

class System408 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component93,Component22>()
.ForEach((ref Component84 c1,ref Component5 c2 ) =>{ }).Run(); }
}

class System409 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component2>()
.ForEach((ref Component345 c1,ref Component303 c2 ) =>{ }).Run(); }
}

class System410 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component357>()
.ForEach((ref Component376 c1,ref Component428 c2 ) =>{ }).Run(); }
}

class System411 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component413 c1 ) =>{ }).Run(); }
}

class System412 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component23>()
.ForEach((ref Component201 c1,ref Component493 c2 ) =>{ }).Run(); }
}

class System413 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component340 c1 ) =>{ }).Run(); }
}

class System414 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component391 c1,ref Component211 c2 ) =>{ }).Run(); }
}

class System415 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component219 c1,ref Component210 c2 ) =>{ }).Run(); }
}

class System416 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component307,Component124>()
.ForEach((ref Component384 c1,ref Component452 c2 ) =>{ }).Run(); }
}

class System417 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component198,Component176>()
.ForEach((ref Component385 c1,ref Component234 c2 ) =>{ }).Run(); }
}

class System418 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component427,Component445>()
.ForEach((ref Component24 c1,ref Component104 c2 ) =>{ }).Run(); }
}

class System419 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component68,Component152>()
.ForEach((ref Component117 c1,ref Component208 c2 ) =>{ }).Run(); }
}

class System420 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component81,Component353>()
.ForEach((ref Component368 c1,ref Component407 c2 ) =>{ }).Run(); }
}

class System421 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component429 c1,ref Component265 c2 ) =>{ }).Run(); }
}

class System422 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component385>()
.ForEach((ref Component193 c1,ref Component293 c2 ) =>{ }).Run(); }
}

class System423 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component418>()
.ForEach((ref Component77 c1,ref Component466 c2 ) =>{ }).Run(); }
}

class System424 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component499 c1 ) =>{ }).Run(); }
}

class System425 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component385>()
.ForEach((ref Component463 c1,ref Component471 c2 ) =>{ }).Run(); }
}

class System426 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component97 c1,ref Component227 c2 ) =>{ }).Run(); }
}

class System427 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component394,Component283>()
.ForEach((ref Component418 c1,ref Component180 c2 ) =>{ }).Run(); }
}

class System428 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component66>()
.ForEach((ref Component2 c1,ref Component140 c2 ) =>{ }).Run(); }
}

class System429 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component370>()
.ForEach((ref Component10 c1,ref Component477 c2 ) =>{ }).Run(); }
}

class System430 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component120,Component415>()
.ForEach((ref Component497 c1,ref Component35 c2 ) =>{ }).Run(); }
}

class System431 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component382 c1 ) =>{ }).Run(); }
}

class System432 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component221 c1 ) =>{ }).Run(); }
}

class System433 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component460 c1 ) =>{ }).Run(); }
}

class System434 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component340 c1 ) =>{ }).Run(); }
}

class System435 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component456 c1 ) =>{ }).Run(); }
}

class System436 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component181 c1 ) =>{ }).Run(); }
}

class System437 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component153 c1 ) =>{ }).Run(); }
}

class System438 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component207>()
.ForEach((ref Component354 c1,ref Component385 c2 ) =>{ }).Run(); }
}

class System439 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component370 c1,ref Component35 c2 ) =>{ }).Run(); }
}

class System440 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component236,Component258>()
.ForEach((ref Component291 c1,ref Component245 c2 ) =>{ }).Run(); }
}

class System441 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component45,Component255>()
.ForEach((ref Component441 c1,ref Component178 c2 ) =>{ }).Run(); }
}

class System442 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component209,Component214>()
.ForEach((ref Component351 c1,ref Component469 c2 ) =>{ }).Run(); }
}

class System443 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component246 c1,ref Component391 c2 ) =>{ }).Run(); }
}

class System444 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component367 c1,ref Component443 c2 ) =>{ }).Run(); }
}

class System445 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component46 c1,ref Component35 c2 ) =>{ }).Run(); }
}

class System446 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component167,Component16>()
.ForEach((ref Component312 c1,ref Component356 c2 ) =>{ }).Run(); }
}

class System447 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component289 c1 ) =>{ }).Run(); }
}

class System448 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component84>()
.ForEach((ref Component249 c1,ref Component380 c2 ) =>{ }).Run(); }
}

class System449 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component343 c1 ) =>{ }).Run(); }
}

class System450 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component85,Component161>()
.ForEach((ref Component268 c1,ref Component4 c2 ) =>{ }).Run(); }
}

class System451 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component200 c1 ) =>{ }).Run(); }
}

class System452 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component330 c1,ref Component36 c2 ) =>{ }).Run(); }
}

class System453 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component138,Component315>()
.ForEach((ref Component95 c1,ref Component215 c2 ) =>{ }).Run(); }
}

class System454 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component2 c1 ) =>{ }).Run(); }
}

class System455 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component265 c1 ) =>{ }).Run(); }
}

class System456 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component210 c1,ref Component350 c2 ) =>{ }).Run(); }
}

class System457 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component161,Component476>()
.ForEach((ref Component99 c1,ref Component274 c2 ) =>{ }).Run(); }
}

class System458 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component89,Component124>()
.ForEach((ref Component140 c1,ref Component101 c2 ) =>{ }).Run(); }
}

class System459 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component295 c1 ) =>{ }).Run(); }
}

class System460 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component282>()
.ForEach((ref Component123 c1,ref Component215 c2 ) =>{ }).Run(); }
}

class System461 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component358>()
.ForEach((ref Component82 c1,ref Component345 c2 ) =>{ }).Run(); }
}

class System462 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component276 c1 ) =>{ }).Run(); }
}

class System463 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component430,Component474>()
.ForEach((ref Component71 c1,ref Component301 c2 ) =>{ }).Run(); }
}

class System464 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component319>()
.ForEach((ref Component246 c1,ref Component289 c2 ) =>{ }).Run(); }
}

class System465 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component321>()
.ForEach((ref Component133 c1,ref Component135 c2 ) =>{ }).Run(); }
}

class System466 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component96,Component235>()
.ForEach((ref Component311 c1,ref Component0 c2 ) =>{ }).Run(); }
}

class System467 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component228 c1 ) =>{ }).Run(); }
}

class System468 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component419,Component377>()
.ForEach((ref Component319 c1,ref Component471 c2 ) =>{ }).Run(); }
}

class System469 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component314 c1,ref Component220 c2 ) =>{ }).Run(); }
}

class System470 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component351>()
.ForEach((ref Component183 c1,ref Component400 c2 ) =>{ }).Run(); }
}

class System471 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component202>()
.ForEach((ref Component170 c1,ref Component186 c2 ) =>{ }).Run(); }
}

class System472 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component383>()
.ForEach((ref Component45 c1,ref Component490 c2 ) =>{ }).Run(); }
}

class System473 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component279>()
.ForEach((ref Component300 c1,ref Component305 c2 ) =>{ }).Run(); }
}

class System474 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component125 c1,ref Component301 c2 ) =>{ }).Run(); }
}

class System475 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component485>()
.ForEach((ref Component470 c1,ref Component281 c2 ) =>{ }).Run(); }
}

class System476 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component322 c1 ) =>{ }).Run(); }
}

class System477 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component100>()
.ForEach((ref Component329 c1,ref Component92 c2 ) =>{ }).Run(); }
}

class System478 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component443,Component26>()
.ForEach((ref Component53 c1,ref Component282 c2 ) =>{ }).Run(); }
}

class System479 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component281,Component339>()
.ForEach((ref Component136 c1,ref Component444 c2 ) =>{ }).Run(); }
}

class System480 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component218 c1,ref Component109 c2 ) =>{ }).Run(); }
}

class System481 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component50 c1,ref Component244 c2 ) =>{ }).Run(); }
}

class System482 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component373 c1,ref Component146 c2 ) =>{ }).Run(); }
}

class System483 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component192 c1 ) =>{ }).Run(); }
}

class System484 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component4>()
.ForEach((ref Component251 c1,ref Component389 c2 ) =>{ }).Run(); }
}

class System485 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component27 c1,ref Component197 c2 ) =>{ }).Run(); }
}

class System486 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component341>()
.ForEach((ref Component29 c1,ref Component468 c2 ) =>{ }).Run(); }
}

class System487 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component101 c1 ) =>{ }).Run(); }
}

class System488 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component439,Component328>()
.ForEach((ref Component492 c1,ref Component208 c2 ) =>{ }).Run(); }
}

class System489 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component380>()
.ForEach((ref Component168 c1,ref Component334 c2 ) =>{ }).Run(); }
}

class System490 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component361>()
.ForEach((ref Component150 c1,ref Component90 c2 ) =>{ }).Run(); }
}

class System491 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component434 c1,ref Component365 c2 ) =>{ }).Run(); }
}

class System492 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component452 c1,ref Component182 c2 ) =>{ }).Run(); }
}

class System493 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component408 c1 ) =>{ }).Run(); }
}

class System494 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component301 c1 ) =>{ }).Run(); }
}

class System495 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component451>()
.ForEach((ref Component438 c1,ref Component276 c2 ) =>{ }).Run(); }
}

class System496 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component252 c1,ref Component370 c2 ) =>{ }).Run(); }
}

class System497 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)
.WithAll<Component160>()
.ForEach((ref Component125 c1,ref Component7 c2 ) =>{ }).Run(); }
}

class System498 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component36 c1 ) =>{ }).Run(); }
}

class System499 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
Entities.WithoutBurst()
.WithStoreEntityQueryInField(ref _notifyGroup)

.ForEach((ref Component45 c1,ref Component325 c2 ) =>{ }).Run(); }
}

class System500 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System501 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System502 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System503 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System504 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System505 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System506 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System507 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System508 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System509 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System510 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System511 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System512 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System513 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System514 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System515 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System516 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System517 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System518 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System519 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System520 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System521 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System522 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System523 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System524 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System525 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System526 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System527 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System528 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System529 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System530 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System531 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System532 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System533 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System534 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System535 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System536 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System537 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System538 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System539 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System540 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System541 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System542 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System543 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System544 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System545 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System546 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System547 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System548 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System549 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System550 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System551 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System552 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System553 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System554 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System555 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System556 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System557 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System558 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System559 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System560 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System561 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System562 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System563 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System564 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System565 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System566 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System567 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System568 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System569 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System570 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System571 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System572 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System573 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System574 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System575 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System576 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System577 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System578 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System579 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System580 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System581 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System582 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System583 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System584 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System585 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System586 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System587 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System588 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System589 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System590 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System591 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System592 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System593 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System594 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System595 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System596 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System597 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System598 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System599 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System600 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System601 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System602 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System603 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System604 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System605 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System606 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System607 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System608 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System609 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System610 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System611 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System612 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System613 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System614 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System615 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System616 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System617 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System618 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System619 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System620 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System621 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System622 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System623 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System624 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System625 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System626 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System627 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System628 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System629 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System630 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System631 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System632 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System633 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System634 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System635 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System636 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System637 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System638 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System639 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System640 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System641 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System642 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System643 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System644 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System645 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System646 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System647 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System648 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System649 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System650 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System651 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System652 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System653 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System654 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System655 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System656 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System657 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System658 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System659 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System660 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System661 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System662 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System663 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System664 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System665 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System666 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System667 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System668 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System669 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System670 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System671 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System672 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System673 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System674 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System675 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System676 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System677 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System678 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System679 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System680 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System681 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System682 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System683 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System684 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System685 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System686 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System687 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System688 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System689 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System690 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System691 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System692 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System693 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System694 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System695 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System696 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System697 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System698 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

class System699 : SystemBase{
 private EntityQuery _notifyGroup;
  EntityManager _em;
 protected override void OnCreate(){
  base.OnCreate();
  _em = EntityManager;
  RequireForUpdate(_notifyGroup);
 }
  protected override void OnUpdate(){
 }
}

}
