using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System15 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component480>().Inc<Component214>().Inc<Component24>().Inc<Component340>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component469>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component469>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component37>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component37>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component77>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component77>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component257>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component257>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
