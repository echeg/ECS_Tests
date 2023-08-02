using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System90 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component354>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component287>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component287>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component182>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component182>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component436>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component436>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component150>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component150>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}