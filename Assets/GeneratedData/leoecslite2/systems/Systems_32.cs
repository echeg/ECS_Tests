using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System32 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component94>().Inc<Component36>().Inc<Component383>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component74>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component74>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component371>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component371>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component460>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component460>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component102>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component102>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
