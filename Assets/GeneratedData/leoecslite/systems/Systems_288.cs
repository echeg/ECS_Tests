using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System288 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component178> _p1;
EcsPool<Component410> _p2;
EcsPool<Component343> _pl0;
EcsPool<Component135> _pl1;
EcsPool<Component150> _pl2;
EcsPool<Component47> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component178>().Inc<Component410>().End();
   _p1 = _world.GetPool<Component178>();
   _p2 = _world.GetPool<Component410>();
   _pl0 = _world.GetPool<Component343>();
   _pl1 = _world.GetPool<Component135>();
   _pl2 = _world.GetPool<Component150>();
   _pl3 = _world.GetPool<Component47>();
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
