using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System75 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component81>().Inc<Component440>().Inc<Component444>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component326>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component326>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component443>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component443>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component406>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component406>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component15>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component15>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
