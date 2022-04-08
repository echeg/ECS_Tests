using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System40 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component2>().Inc<Component218>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component169>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component169>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component155>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component155>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component275>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component275>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component475>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component475>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
