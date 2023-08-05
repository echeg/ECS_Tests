using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System308 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component120> _p1;
EcsPool<Component312> _p2;
EcsPool<Component454> _p3;
EcsPool<Component167> _p4;
EcsPool<Component129> _pl0;
EcsPool<Component223> _pl1;
EcsPool<Component177> _pl2;
EcsPool<Component18> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component120>().Inc<Component312>().Inc<Component454>().Inc<Component167>().End();
   _p1 = _world.GetPool<Component120>();
   _p2 = _world.GetPool<Component312>();
   _p3 = _world.GetPool<Component454>();
   _p4 = _world.GetPool<Component167>();
   _pl0 = _world.GetPool<Component129>();
   _pl1 = _world.GetPool<Component223>();
   _pl2 = _world.GetPool<Component177>();
   _pl3 = _world.GetPool<Component18>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
