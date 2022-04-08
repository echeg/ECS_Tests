using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System64 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component177>().Inc<Component360>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component10>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component10>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component137>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component137>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component429>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component429>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component18>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component18>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
